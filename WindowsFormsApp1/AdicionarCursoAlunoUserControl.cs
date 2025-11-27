using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjetoProg.Btn;

namespace WindowsFormsApp1
{
    public partial class AdicionarCursoAlunoUserControl : UserControl
    {
        string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno";
        // Variável de classe para armazenar os dados brutos (não filtrados)
        private DataTable dtCursos = new DataTable();

        public AdicionarCursoAlunoUserControl()
        {
            InitializeComponent();
            CarregarCursos2();
            this.TxbPesquisa.TextChanged += TxbPesquisa_TextChanged_TextChanged;
        }

        private void CarregarCursos2()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // A query faz uma junção (JOIN) para criar uma linha para CADA par (Curso, Professor).
                string query = @"
                    SELECT 
                        CP.ID_CURSO,       
                        C.NOME_CURSO,      
                        C.CARGA_HORARIA,   
                        P.NOME_PROFESSOR AS NOME_PROFESSOR, 
                        P.ID_PROFESSOR
                    FROM
                        CURSOS_PROFESSORES CP   
                    INNER JOIN
                        CURSOS C ON CP.ID_CURSO = C.ID_CURSO
                    INNER JOIN
                        PROFESSORES P ON CP.ID_PROFESSOR = P.ID_PROFESSOR
                    ORDER BY
                        C.NOME_CURSO, P.NOME_PROFESSOR";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                // 1. Preenche a variável de classe (dtCursos) com os dados brutos
                dtCursos.Clear();
                da.Fill(dtCursos);

                DataGridViewStyleHelper.AplicarEstiloPadrao(dataGridView1);

                // 2. Cria uma DataView para a filtragem e a define como DataSource
                DataView dv = new DataView(dtCursos);
                dataGridView1.DataSource = dv;

                // Configuração dos cabeçalhos
                dataGridView1.Columns["NOME_CURSO"].HeaderText = "CURSO";
                dataGridView1.Columns["CARGA_HORARIA"].HeaderText = "CARGA HORÁRIA";
                dataGridView1.Columns["NOME_PROFESSOR"].HeaderText = "PROFESSOR";

                // Colunas ocultas
                dataGridView1.Columns["ID_CURSO"].Visible = false;
                dataGridView1.Columns["ID_PROFESSOR"].Visible = false;
            }
        }



        private void AdicionarCursoAlunoUserControl_Load(object sender, EventArgs e)
        {

        }

        private void BtnNewCourse_Click(object sender, EventArgs e)
        {
            
            // Acessar a sessão do Aluno logado (Ajuste conforme sua variável de sessão)
            string emailAluno = SessaoUsuario.Email;
            int idCursoSelecionado;
            object idAlunoPK = null;

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um curso na lista para se matricular.", "Erro de Seleção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            idCursoSelecionado = Convert.ToInt32(selectedRow.Cells["ID_CURSO"].Value);
            string nomeCurso = selectedRow.Cells["NOME_CURSO"].Value.ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // PASSO 1: BUSCAR O ID_ALUNO
                // Assumindo que sua tabela de Alunos se chame ALUNOS e use EMAIL_ALUNO
                SqlCommand getIdCmd = new SqlCommand(
                    "SELECT ID_ALUNO FROM ALUNOS WHERE EMAIL_ALUNO = @email", conn);
                getIdCmd.Parameters.AddWithValue("@email", emailAluno);

                idAlunoPK = getIdCmd.ExecuteScalar();

                if (idAlunoPK == null)
                {
                    MessageBox.Show("Erro: Aluno logado não encontrado na base de dados.", "Erro de Sessão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // PASSO 2: VERIFICAR SE O ALUNO JÁ ESTÁ MATRICULADO
                SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM ALUNOS_CURSOS WHERE ID_ALUNO = @alunoId AND ID_CURSO = @cursoId", conn);
                checkCmd.Parameters.AddWithValue("@alunoId", idAlunoPK);
                checkCmd.Parameters.AddWithValue("@cursoId", idCursoSelecionado);

                int jaMatriculado = (int)checkCmd.ExecuteScalar();

                if (jaMatriculado > 0)
                {
                    MessageBox.Show($"Você já está matriculado no curso '{nomeCurso}'.", "Matrícula Existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // PASSO 3: INSERIR A MATRÍCULA
                SqlCommand insertCmd = new SqlCommand(
                    "INSERT INTO ALUNOS_CURSOS (ID_ALUNO, ID_CURSO) VALUES (@alunoId, @cursoId)", conn);
                insertCmd.Parameters.AddWithValue("@alunoId", idAlunoPK);
                insertCmd.Parameters.AddWithValue("@cursoId", idCursoSelecionado);
                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Matrícula realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TxbPesquisa_TextChanged_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltroPesquisa();
        }

        private void AplicarFiltroPesquisa()
        {
            // O nome "TxbPesquisa" deve ser o nome da sua TextBox no Designer
            string filtro = TxbPesquisa.Text.Trim();

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

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
    }
