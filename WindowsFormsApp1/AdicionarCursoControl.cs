using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjetoProg.Btn;

namespace WindowsFormsApp1
{
    public partial class AdicionarCursoControl : UserControl
    {
        string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno";
        private DataTable dtCursos = new DataTable();

        public AdicionarCursoControl()
        {
            InitializeComponent();
            CarregarCursos();
            this.TxbPesquisa3.TextChanged += TxbPesquisa3_TextChanged_TextChanged;
        }

        private void CarregarCursos()
        {
            // Garante que o objeto DataTable exista (embora já declarado na classe)
            if (dtCursos == null)
            {
                dtCursos = new DataTable();
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT CP.ID_CURSO, C.NOME_CURSO, C.CARGA_HORARIA, P.NOME_PROFESSOR AS NOME_PROFESSOR, P.ID_PROFESSOR
            FROM CURSOS_PROFESSORES CP
            INNER JOIN CURSOS C ON CP.ID_CURSO = C.ID_CURSO
            INNER JOIN PROFESSORES P ON CP.ID_PROFESSOR = P.ID_PROFESSOR
            ORDER BY C.NOME_CURSO, P.NOME_PROFESSOR";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                // 1. Limpa o DataTable antes de recarregar
                dtCursos.Clear();

                // 2. Preenche a variável de classe (dtCursos) com os novos dados brutos
                da.Fill(dtCursos);

                DataGridViewStyleHelper.AplicarEstiloPadrao(dataGridView1);

                // 3. Cria uma DataView para a filtragem e a define como DataSource
                // NOTA: É fundamental que o DataGridView continue usando o DataView,
                // pois é ele quem aplica o filtro da pesquisa (TxbPesquisa3_TextChanged).
                DataView dv = new DataView(dtCursos);
                dataGridView1.DataSource = dv;

                // ... (O restante da configuração das colunas) ...
                dataGridView1.Columns["NOME_CURSO"].HeaderText = "CURSO";
                dataGridView1.Columns["CARGA_HORARIA"].HeaderText = "CARGA HORÁRIA";
                dataGridView1.Columns["NOME_PROFESSOR"].HeaderText = "PROFESSOR";
                dataGridView1.Columns["ID_CURSO"].Visible = false;
                dataGridView1.Columns["ID_PROFESSOR"].Visible = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeCurso = TxbNomeCurso.Text.Trim();
            string cargaHoraria = TxbCargaHoraria.Text.Trim();

            // Obter o ID do professor logado
            string emailProfessor = SessaoUsuario.Email;
            object idProfessorPK = null; // Vamos buscar o PK

            if (nomeCurso == "" || cargaHoraria == "")
            {
                MessageBox.Show("Preencha todos os campos antes de adicionar o curso.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction(); // Usar transação para 2 INSERTs

                try
                {
                    // PASSO 0: OBTER O ID DO PROFESSOR (CHAVE PRIMÁRIA)
                    SqlCommand getIdCmd = new SqlCommand("SELECT ID_PROFESSOR FROM PROFESSORES WHERE EMAIL_PROFESSOR = @email", conn, transaction);
                    getIdCmd.Parameters.AddWithValue("@email", emailProfessor);
                    idProfessorPK = getIdCmd.ExecuteScalar();

                    if (idProfessorPK == null)
                    {
                        MessageBox.Show("Erro: Professor logado não encontrado.", "Erro");
                        transaction.Rollback();
                        return;
                    }

                    // PASSO 1: VERIFICAR DUPLICIDADE (mantido)
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM CURSOS WHERE NOME_CURSO = @nome AND CARGA_HORARIA = @carga", conn, transaction);
                    checkCmd.Parameters.AddWithValue("@nome", nomeCurso);
                    checkCmd.Parameters.AddWithValue("@carga", cargaHoraria);
                    int existe = (int)checkCmd.ExecuteScalar();

                    if (existe > 0)
                    {
                        MessageBox.Show("Esse curso já existe no banco de dados.");
                        transaction.Rollback();
                        return;
                    }

                    // PASSO 2: INSERIR O NOVO CURSO e OBTER O ID
                    SqlCommand insertCursoCmd = new SqlCommand(
                        "INSERT INTO CURSOS (NOME_CURSO, CARGA_HORARIA) VALUES (@nome, @carga); SELECT SCOPE_IDENTITY();", conn, transaction);
                    insertCursoCmd.Parameters.AddWithValue("@nome", nomeCurso);
                    insertCursoCmd.Parameters.AddWithValue("@carga", cargaHoraria);

                    // EXECUTA O INSERT E PEGA O ID_CURSO RECÉM-CRIADO (se ID_CURSO for IDENTITY)
                    int novoIdCurso = Convert.ToInt32(insertCursoCmd.ExecuteScalar());

                    // PASSO 3: INSERIR O VÍNCULO DO PROFESSOR COM O NOVO CURSO
                    SqlCommand insertVinculoCmd = new SqlCommand(
                        "INSERT INTO CURSOS_PROFESSORES (ID_PROFESSOR, ID_CURSO) VALUES (@profId, @cursoId)", conn, transaction);
                    insertVinculoCmd.Parameters.AddWithValue("@profId", idProfessorPK);
                    insertVinculoCmd.Parameters.AddWithValue("@cursoId", novoIdCurso);
                    insertVinculoCmd.ExecuteNonQuery();

                    // SUCESSO: Confirma as duas inserções
                    transaction.Commit();

                    // PASSO 4: RECARRGAR A LISTA
                    CarregarCursos();

                    MessageBox.Show("Curso adicionado e vinculado com sucesso!");
                    TxbNomeCurso.Text = "";
                    TxbCargaHoraria.Text = "";
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Erro ao adicionar curso: " + ex.Message);
                }
            }
        }

        private void BtnSaveCourse_Click(object sender, EventArgs e)
        {
            string emailProfessor = SessaoUsuario.Email;
            int idCurso;
            object idProfessorPK = null;

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um curso na lista.");
                return;
            }

            // Obtém o ID e o Nome do Curso selecionado para usar na mensagem de erro.
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            idCurso = Convert.ToInt32(selectedRow.Cells["ID_CURSO"].Value);
            string nomeCurso = selectedRow.Cells["NOME_CURSO"].Value.ToString(); // Assumindo que a coluna NOME_CURSO está como "CURSO"

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // =========================================================================
                // PASSO 1: BUSCAR O ID_PROFESSOR (CHAVE PRIMÁRIA/Referenciada) COM BASE NO EMAIL
                // Isso resolve o erro de FOREIGN KEY, pois usa o ID correto para o banco.
                // =========================================================================
                SqlCommand getIdCmd = new SqlCommand(
                    "SELECT ID_PROFESSOR FROM PROFESSORES WHERE EMAIL_PROFESSOR = @email", conn);
                getIdCmd.Parameters.AddWithValue("@email", emailProfessor);

                idProfessorPK = getIdCmd.ExecuteScalar();

                if (idProfessorPK == null)
                {
                    MessageBox.Show("Erro: Professor logado não encontrado na tabela PROFESSORES. Verifique o cadastro.");
                    return;
                }

                // =========================================================================
                // PASSO 2: VERIFICAR VÍNCULO EXISTENTE (Aprimorado)
                // =========================================================================

                // Verifica se o professor já está vinculado a esse curso usando o ID_PROFESSOR
                SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM CURSOS_PROFESSORES WHERE ID_PROFESSOR = @profId AND ID_CURSO = @curso", conn);
                checkCmd.Parameters.AddWithValue("@profId", idProfessorPK); // Usando o ID_PROFESSOR correto
                checkCmd.Parameters.AddWithValue("@curso", idCurso);

                int existe = (int)checkCmd.ExecuteScalar();

                if (existe > 0)
                {
                    // Mensagem personalizada conforme solicitado
                    MessageBox.Show($"Você já está vinculado ao curso '{nomeCurso}' e não pode se vincular novamente.", "Vínculo Existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // =========================================================================
                // PASSO 3: INSERIR O VÍNCULO
                // =========================================================================

                // Insere o vínculo
                SqlCommand insertCmd = new SqlCommand(
                    "INSERT INTO CURSOS_PROFESSORES (ID_PROFESSOR, ID_CURSO) VALUES (@profId, @curso)", conn);
                insertCmd.Parameters.AddWithValue("@profId", idProfessorPK);
                insertCmd.Parameters.AddWithValue("@curso", idCurso);
                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Curso vinculado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LblCargaHoraria_Click(object sender, EventArgs e)
        {

        }

        private void TxbPesquisa3_TextChanged_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltroPesquisa();
        }

        private void AplicarFiltroPesquisa()
        {
            // O nome "TxbPesquisa" deve ser o nome da sua TextBox no Designer
            string filtro = TxbPesquisa3.Text.Trim();

            // Certifica-se de que estamos trabalhando com uma DataView
            if (dataGridView1.DataSource is DataView dv)
            {
                if (string.IsNullOrEmpty(filtro))
                {
                    // Se a pesquisa estiver vazia, remove o filtro
                    dv.RowFilter = string.Empty;
                }
                else
                {
                    // Cria a expressão de filtro para buscar na coluna de Curso OU na de Professor
                    // Usamos LIKE '%{filtro}%' para buscas parciais
                    string expressaoFiltro =
                        $"NOME_CURSO LIKE '%{filtro}%' OR NOME_PROFESSOR LIKE '%{filtro}%'";

                    try
                    {
                        dv.RowFilter = expressaoFiltro;
                    }
                    catch (Exception ex)
                    {
                        // Mensagem de erro caso a sintaxe do filtro esteja incorreta
                        MessageBox.Show("Erro ao aplicar filtro: " + ex.Message, "Erro de Filtro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dv.RowFilter = string.Empty;
                    }
                }
            }
        }

        private void AdicionarCursoControl_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}


