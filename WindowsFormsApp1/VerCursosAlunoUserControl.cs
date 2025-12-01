using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static ProjetoProg.Btn;

namespace WindowsFormsApp1
{
    public partial class VerCursosAlunoUserControl : UserControl
    {
        // Connection string
        private const string ConnectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno";
        private DataTable dtCursos = new DataTable();

        public VerCursosAlunoUserControl()
        {
            InitializeComponent();

            // Configuração do DataGridView
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.ReadOnly = true;

            // Evento de pesquisa
            this.TxbPesquisa2.TextChanged += TxbPesquisa2_TextChanged;
        }


        private void VerCursosAlunoUserControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                CarregarCursosDoAluno();
            }
        }

        private void CarregarCursosDoAluno()
        {
            string emailAluno = SessaoUsuario.Email;
            // CORREÇÃO: idAluno agora é uma string (VARCHAR)
            string idAluno = string.Empty;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    // PASSO 1: Buscar o ID_ALUNO (chave primária)
                    SqlCommand getIdCmd = new SqlCommand(
                        "SELECT ID_ALUNO FROM ALUNOS WHERE EMAIL_ALUNO = @email", conn);
                    getIdCmd.Parameters.AddWithValue("@email", emailAluno);
                    object idAlunoPK = getIdCmd.ExecuteScalar();

                    if (idAlunoPK == null || idAlunoPK == DBNull.Value)
                    {
                        MessageBox.Show("Erro: Aluno logado não encontrado na base de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // CORREÇÃO CRÍTICA: Atribui o valor como string, sem conversão forçada
                    idAluno = idAlunoPK.ToString();

                    // PASSO 2: Buscar os cursos
                    // Adicionando DISTINCT para evitar duplicação de cursos com vários professores
                    string query = @"
                        SELECT DISTINCT 
                            C.ID_CURSO,
                            C.NOME_CURSO AS NomeCurso,
                            C.CARGA_HORARIA AS CargaHoraria,
                            P.NOME_PROFESSOR AS Professor
                        FROM 
                            ALUNOS_CURSOS AC
                            INNER JOIN CURSOS C ON AC.ID_CURSO = C.ID_CURSO
                            INNER JOIN CURSOS_PROFESSORES CP ON C.ID_CURSO = CP.ID_CURSO
                            INNER JOIN PROFESSORES P ON CP.ID_PROFESSOR = P.ID_PROFESSOR
                        WHERE 
                            AC.ID_ALUNO = @idAluno";


                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    // Passa o ID como string (o SqlClient infere o tipo, mas a variável agora é string)
                    da.SelectCommand.Parameters.AddWithValue("@idAluno", idAluno);

                    // Preenche a variável de classe com os dados brutos
                    dtCursos.Clear();
                    da.Fill(dtCursos);

                    // Verifica se o estilo padrão está disponível antes de tentar aplicá-lo
                    if (typeof(DataGridViewStyleHelper).GetMethod("AplicarEstiloPadrao") != null)
                    {
                        DataGridViewStyleHelper.AplicarEstiloPadrao(dataGridView3);
                    }

                    // PASSO 3: Gerenciar a exibição
                    if (dtCursos.Rows.Count > 0)
                    {
                        // Usa a DataView para permitir a filtragem
                        DataView dv = new DataView(dtCursos);
                        dataGridView3.DataSource = dv;

                        // Configuração das colunas
                        // Certifica-se de que os nomes das colunas estão corretos (NomeCurso, CargaHoraria, Professor)
                        if (dataGridView3.Columns.Contains("ID_CURSO")) dataGridView3.Columns["ID_CURSO"].Visible = false;
                        if (dataGridView3.Columns.Contains("NomeCurso")) dataGridView3.Columns["NomeCurso"].HeaderText = "Nome do Curso";
                        if (dataGridView3.Columns.Contains("CargaHoraria")) dataGridView3.Columns["CargaHoraria"].HeaderText = "Carga Horária (h)";
                        if (dataGridView3.Columns.Contains("Professor")) dataGridView3.Columns["Professor"].HeaderText = "Professor(a)";

                        dataGridView3.Visible = true;
                        TxbPesquisa2.Visible = true;
                        pictureBox1.Visible = true;

                        if (LblSemCurso != null)
                        {
                            LblSemCurso.Visible = false;
                        }
                    }
                    else
                    {
                        dataGridView3.Visible = false;
                        TxbPesquisa2.Visible = false;
                        pictureBox1.Visible = false;

                        if (LblSemCurso != null)
                        {
                            LblSemCurso.Visible = true;
                            LblSemCurso.Text = "Você não está matriculado em nenhum curso.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Mensagem de erro que agora não deve ser mais a de "Formato Incorreto"
                    MessageBox.Show("Erro ao carregar cursos: " + ex.Message, "Erro de Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TxbPesquisa2_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltroPesquisa();
        }

        private void AplicarFiltroPesquisa()
        {
            string filtro = TxbPesquisa2.Text.Trim();

            // Certifica-se de que estamos trabalhando com uma DataView
            if (dataGridView3.DataSource is DataView dv)
            {
                if (string.IsNullOrEmpty(filtro))
                {
                    // Se a pesquisa estiver vazia, remove o filtro
                    dv.RowFilter = string.Empty;
                }
                else
                {
                    // Cria a expressão de filtro para buscar na coluna de Curso OU na de Professor
                    string expressaoFiltro =
                        $"NomeCurso LIKE '%{filtro}%' OR Professor LIKE '%{filtro}%'";

                    try
                    {
                        dv.RowFilter = expressaoFiltro;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao aplicar filtro: " + ex.Message, "Erro de Filtro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dv.RowFilter = string.Empty;
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Deixado vazio
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Deixado vazio
        }

        private void LblSemCurso_Click(object sender, EventArgs e)
        {
            // Deixado vazio
        }

        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Deixado vazio
        }
    }
}