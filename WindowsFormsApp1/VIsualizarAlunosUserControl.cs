using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    // O nome da classe deve ser o mesmo do arquivo designer: VisualizarAlunosUserControl
    public partial class VisualizarAlunosUserControl : UserControl
    {
        // VARIÁVEIS DE MEMBRO (DEFINIDAS DENTRO DA CLASSE, NÃO DENTRO DE UM MÉTODO)
        string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno";
        private int idCursoSelecionado;
        private string nomeCurso; // Opcional, para exibição de título

        // CONSTRUTOR PADRÃO (Necessário para o Designer)
        public VisualizarAlunosUserControl()
        {
            InitializeComponent();
        }

        // CONSTRUTOR CORRETO (Recebe o ID do curso)
        public VisualizarAlunosUserControl(int idCurso, string cursoNome) : this()
        {
            // O ': this()' chama o InitializeComponent()
            this.idCursoSelecionado = idCurso;
            this.nomeCurso = cursoNome;

            // Opcional: Defina a Label ou o Título aqui
            // Exemplo: LblTitulo.Text = $"Alunos Matriculados em: {cursoNome}";
        }

        // EVENTO LOAD (Inicia o carregamento dos dados)
        private void VisualizarAlunosUserControl_Load(object sender, EventArgs e)
        {
            CarregarAlunosDoCurso();
        }

        private void CarregarAlunosDoCurso()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query para buscar Alunos pelo ID_CURSO
                    string query = @"
                        SELECT
                            A.ID_ALUNO,
                            A.NOME_ALUNO,
                            A.EMAIL_ALUNO
                        FROM
                            ALUNOS A
                        INNER JOIN
                            ALUNOS_CURSOS AC ON A.ID_ALUNO = AC.ID_ALUNO
                        WHERE
                            AC.ID_CURSO = @idCurso";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    // Usa a variável de membro correta
                    da.SelectCommand.Parameters.AddWithValue("@idCurso", idCursoSelecionado);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Assumindo que você tem um DataGridView chamado 'dataGridViewAlunos' neste controle
                    if (dt.Rows.Count > 0)
                    {
                        dataGridViewAlunos.DataSource = dt;

                        // Configuração de cabeçalhos
                        dataGridViewAlunos.Columns["ID_ALUNO"].Visible = false;
                        dataGridViewAlunos.Columns["NOME_ALUNO"].HeaderText = "NOME DO ALUNO";
                        dataGridViewAlunos.Columns["EMAIL_ALUNO"].HeaderText = "EMAIL";
                    }
                    else
                    {
                        MessageBox.Show($"Nenhum aluno matriculado em '{nomeCurso}'.", "Informação");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar lista de alunos: " + ex.Message);
                }
            }
        }
    }
}