using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static ProjetoProg.Btn;

namespace WindowsFormsApp1
{
    public partial class VisualizarProfessorUserControl : UserControl
    {
        string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno";
        private DataTable dtProfessoresConsolidado = new DataTable();

        public VisualizarProfessorUserControl()
        {
            InitializeComponent();

            // Apenas associa o evento de clique duplo.
            dataGridViewProfessores.CellDoubleClick += dataGridViewProfessores_CellDoubleClick;
        }

        private void VisualizarProfessorUserControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                CarregarTodosOsProfessores();
            }
        }

        private void CarregarTodosOsProfessores()
        {
            // O aluno logado é determinado pelo Email na SessaoUsuario
            string emailAluno = SessaoUsuario.Email;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // PASSO 1: Buscar o ID_ALUNO (chave primária)
                    SqlCommand getIdCmd = new SqlCommand(
                        "SELECT ID_ALUNO FROM ALUNOS WHERE EMAIL_ALUNO = @email", conn);
                    getIdCmd.Parameters.AddWithValue("@email", emailAluno);
                    object idAlunoPK = getIdCmd.ExecuteScalar();

                    if (idAlunoPK == null)
                    {
                        MessageBox.Show("Erro: Aluno logado não encontrado na base de dados.", "Erro de Sessão");
                        return;
                    }
                    string idAluno = idAlunoPK.ToString();

                    // PASSO 2: Query para buscar Professores, Cursos e E-mails associados ao ALUNO
                    string query = @"
                        SELECT DISTINCT
                            P.NOME_PROFESSOR,
                            C.NOME_CURSO,
                            P.EMAIL_PROFESSOR,
                            P.ID_PROFESSOR
                        FROM
                            PROFESSORES P
                        INNER JOIN CURSOS_PROFESSORES CP ON P.ID_PROFESSOR = CP.ID_PROFESSOR
                        INNER JOIN CURSOS C ON CP.ID_CURSO = C.ID_CURSO
                        INNER JOIN ALUNOS_CURSOS AC ON C.ID_CURSO = AC.ID_CURSO
                        WHERE 
                            AC.ID_ALUNO = @idAluno
                        ORDER BY
                            P.NOME_PROFESSOR";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@idAluno", idAluno);

                    dtProfessoresConsolidado.Clear();
                    da.Fill(dtProfessoresConsolidado);

                    // PASSO 3: Gerenciar a exibição
                    if (dtProfessoresConsolidado.Rows.Count > 0)
                    {
                        dataGridViewProfessores.DataSource = dtProfessoresConsolidado;
                        dataGridViewProfessores.Visible = true;

                        // Configuração MÍNIMA: Oculta a chave primária e define os cabeçalhos
                        dataGridViewProfessores.Columns["ID_PROFESSOR"].Visible = false;
                        dataGridViewProfessores.Columns["NOME_PROFESSOR"].HeaderText = "NOME DO PROFESSOR";
                        dataGridViewProfessores.Columns["NOME_CURSO"].HeaderText = "DISCIPLINA";
                        dataGridViewProfessores.Columns["EMAIL_PROFESSOR"].HeaderText = "E-MAIL";
                    }
                    else
                    {
                        dataGridViewProfessores.Visible = false;
                        MessageBox.Show("Você não está matriculado em nenhum curso com professores associados.", "Informação");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar lista de professores: " + ex.Message, "Erro de Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewProfessores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string nomeProfessor = dataGridViewProfessores.Rows[e.RowIndex].Cells["NOME_PROFESSOR"].Value.ToString();
            string emailProfessor = dataGridViewProfessores.Rows[e.RowIndex].Cells["EMAIL_PROFESSOR"].Value.ToString();

            MessageBox.Show($"Você selecionou o professor: {nomeProfessor} ({emailProfessor}).\nPróxima Ação: Perfil ou E-mail.", "Ação Selecionada");

            // Implementação da próxima ação (e.g., abrir um formulário para enviar e-mail)
        }
    }
}