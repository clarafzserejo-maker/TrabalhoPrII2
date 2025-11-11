using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static ProjetoProg.Btn;

// Assumindo que a classe SessaoUsuario e ProjetoProg.Btn estão definidas em outro lugar
// e que SessaoUsuario tem a propriedade IdUsuario (string)

namespace WindowsFormsApp1
{
    public partial class VisualizarAgendaUserControl : UserControl
    {
        // Variável de conexão definida na classe
        private const string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno";

        public VisualizarAgendaUserControl()
        {
            InitializeComponent();
        }

        private void VisualizarAgendaUserControl_Load(object sender, EventArgs e)
        {
            // O código de carregamento deve ser inteligente para saber quem está logado
            CarregarTodasAulasAgendadas();
        }

        // Método principal que decide qual consulta executar, verificando o tipo no DB
        private void CarregarTodasAulasAgendadas()
        {
            string idUsuario = SessaoUsuario.IdUsuario;

            if (string.IsNullOrEmpty(idUsuario))
            {
                MessageBox.Show("Erro de sessão. ID do usuário não identificado.", "Erro");
                DgvAgenda.DataSource = null;
                return;
            }

            // 1. Tenta carregar como Professor
            if (CarregarAulasProfessor(idUsuario))
            {
                // Se o carregamento como Professor foi bem-sucedido, terminamos aqui.
                return;
            }

            // 2. Se falhou como Professor (provavelmente não é um), tenta carregar como Aluno
            // Nota: O método CarregarAulasProfessor/Aluno agora retorna bool indicando sucesso/falha
            CarregarAulasAluno(idUsuario);
        }

        // =========================================================================
        // VISÃO DO PROFESSOR (Professor vê: Disciplina, Data, Hora, Aluno)
        // Retorna true se encontrou dados, false se não encontrou (e o ID não era de professor)
        // =========================================================================
        private bool CarregarAulasProfessor(string idProfessorStr)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Consulta que traz as aulas do professor logado.
                    // Adicionei COUNT(*) para verificar se o ID pertence à tabela PROFESSORES
                    string query = @"
                        SELECT 
                            A.DATA_HORA AS DATA_HORA_COMPLETA,
                            CONVERT(VARCHAR(10), A.DATA_HORA, 103) AS DATA,
                            CONVERT(VARCHAR(5), A.DATA_HORA, 108) AS HORA,
                            C.NOME_CURSO AS DISCIPLINA,
                            L.NOME_ALUNO AS ALUNO
                        FROM 
                            AULAS_AGENDADAS A
                        INNER JOIN CURSOS C ON A.ID_CURSO = C.ID_CURSO
                        INNER JOIN ALUNOS L ON A.ID_ALUNO = L.ID_ALUNO
                        WHERE 
                            A.ID_PROFESSOR = @idProfessor
                        ORDER BY
                            A.DATA_HORA ASC";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@idProfessor", idProfessorStr);

                    DataTable dtAulas = new DataTable();
                    dtAulas.Load(cmd.ExecuteReader());

                    if (dtAulas.Rows.Count > 0)
                    {
                        DgvAgenda.DataSource = dtAulas;
                        AjustarDgvProfessor(dtAulas);
                        return true; // Encontrou dados, é professor
                    }

                    // Não encontrou aulas, mas o usuário ainda pode ser professor. 
                    // Vamos tentar uma verificação mais simples para confirmar o tipo.
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(ID_PROFESSOR) FROM PROFESSORES WHERE ID_PROFESSOR = @id", con);
                    checkCmd.Parameters.AddWithValue("@id", idProfessorStr);
                    int isProfessor = (int)checkCmd.ExecuteScalar();

                    if (isProfessor > 0)
                    {
                        // É professor, mas não tem aulas. Limpa o DGV e retorna true (sucesso na identificação)
                        DgvAgenda.DataSource = dtAulas;
                        return true;
                    }

                    return false; // Não é professor, continue a busca.
                }
                catch (Exception ex)
                {
                    // Em caso de erro, trate e retorne false
                    MessageBox.Show("Erro ao carregar agenda do professor: " + ex.Message, "Erro de Banco de Dados");
                    return false;
                }
            }
        }

        // =========================================================================
        // VISÃO DO ALUNO (Aluno vê: Disciplina, Data, Hora, Professor)
        // Retorna true se encontrou dados, false se não encontrou.
        // =========================================================================
        private bool CarregarAulasAluno(string idAlunoStr)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Consulta que traz as aulas do aluno logado.
                    string query = @"
                        SELECT 
                            A.DATA_HORA AS DATA_HORA_COMPLETA,
                            CONVERT(VARCHAR(10), A.DATA_HORA, 103) AS DATA,
                            CONVERT(VARCHAR(5), A.DATA_HORA, 108) AS HORA,
                            C.NOME_CURSO AS DISCIPLINA,
                            P.NOME_PROFESSOR AS PROFESSOR
                        FROM 
                            AULAS_AGENDADAS A
                        INNER JOIN CURSOS C ON A.ID_CURSO = C.ID_CURSO
                        INNER JOIN PROFESSORES P ON A.ID_PROFESSOR = P.ID_PROFESSOR
                        WHERE 
                            A.ID_ALUNO = @idAluno
                        ORDER BY
                            A.DATA_HORA ASC";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@idAluno", idAlunoStr);

                    DataTable dtAulas = new DataTable();
                    dtAulas.Load(cmd.ExecuteReader());

                    DgvAgenda.DataSource = dtAulas;

                    if (dtAulas.Rows.Count > 0)
                    {
                        AjustarDgvAluno(dtAulas);
                        return true; // Encontrou dados, é aluno
                    }
                    else
                    {
                        // Não encontrou aulas, mas o usuário ainda pode ser aluno. 
                        // Vamos tentar uma verificação mais simples para confirmar o tipo.
                        SqlCommand checkCmd = new SqlCommand("SELECT COUNT(ID_ALUNO) FROM ALUNOS WHERE ID_ALUNO = @id", con);
                        checkCmd.Parameters.AddWithValue("@id", idAlunoStr);
                        int isAluno = (int)checkCmd.ExecuteScalar();

                        if (isAluno > 0)
                        {
                            // É aluno, mas não tem aulas. Limpa o DGV e retorna true (sucesso na identificação)
                            DgvAgenda.DataSource = dtAulas;
                            return true;
                        }
                    }

                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar agenda do aluno: " + ex.Message, "Erro de Banco de Dados");
                    return false;
                }
            }
        }

        // Métodos auxiliares para ajustar a visualização (mantidos)
        private void AjustarDgvProfessor(DataTable dtAulas)
        {
            if (dtAulas.Rows.Count > 0)
            {
                DgvAgenda.Columns["DATA_HORA_COMPLETA"].Visible = false;

                DgvAgenda.Columns["DATA"].HeaderText = "Data";
                DgvAgenda.Columns["HORA"].HeaderText = "Hora";
                DgvAgenda.Columns["DISCIPLINA"].HeaderText = "Disciplina";
                DgvAgenda.Columns["ALUNO"].HeaderText = "Aluno";

                DgvAgenda.Columns["DATA"].Width = 90;
                DgvAgenda.Columns["HORA"].Width = 60;
                DgvAgenda.Columns["DISCIPLINA"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DgvAgenda.Columns["ALUNO"].Width = 150;
            }
        }

        private void AjustarDgvAluno(DataTable dtAulas)
        {
            if (dtAulas.Rows.Count > 0)
            {
                DgvAgenda.Columns["DATA_HORA_COMPLETA"].Visible = false;

                DgvAgenda.Columns["DATA"].HeaderText = "Data";
                DgvAgenda.Columns["HORA"].HeaderText = "Hora";
                DgvAgenda.Columns["DISCIPLINA"].HeaderText = "Disciplina";
                DgvAgenda.Columns["PROFESSOR"].HeaderText = "Professor";

                DgvAgenda.Columns["DATA"].Width = 90;
                DgvAgenda.Columns["HORA"].Width = 60;
                DgvAgenda.Columns["DISCIPLINA"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DgvAgenda.Columns["PROFESSOR"].Width = 150;
            }
        }

        private void CalAgenda_DateSelected(object sender, DateRangeEventArgs e)
        {
            // Sem ação de filtro
        }
    }
}