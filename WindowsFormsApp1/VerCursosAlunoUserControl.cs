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
    public partial class VerCursosAlunoUserControl : UserControl
    {
        string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno";
        public VerCursosAlunoUserControl()
        {
            InitializeComponent();

            // Permite que a linha inteira seja selecionada e clicável
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.ReadOnly = true; // Apenas visualização

            // Adiciona o evento para lidar com o clique na linha
            dataGridView3.CellDoubleClick += dataGridView3_CellDoubleClick;
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

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // PASSO 1: Buscar o ID_PROFESSOR (chave primária)
                    SqlCommand getIdCmd = new SqlCommand(
                        "SELECT ID_ALUNO FROM ALUNOS WHERE EMAIL_ALUNO = @email", conn);
                    getIdCmd.Parameters.AddWithValue("@email", emailAluno);
                    object idAlunoPK = getIdCmd.ExecuteScalar();

                    if (idAlunoPK == null) { /* ... (mensagem de erro) ... */ return; }
                    string idAluno = idAlunoPK.ToString();

                    // PASSO 2: Buscar os cursos (Incluindo ID_CURSO, pois ele é necessário para a próxima tela)
                    string query = @"
    SELECT 
        C.ID_CURSO,
        C.NOME_CURSO AS NOME_CURSO,
        C.CARGA_HORARIA AS CARGA_HORARIA,
        P.NOME_PROFESSOR AS NOME_PROFESSOR
    FROM 
        ALUNOS_CURSOS AC
        INNER JOIN CURSOS C ON AC.ID_CURSO = C.ID_CURSO
        INNER JOIN CURSOS_PROFESSORES CP ON C.ID_CURSO = CP.ID_CURSO
        INNER JOIN PROFESSORES P ON CP.ID_PROFESSOR = P.ID_PROFESSOR
    WHERE 
        AC.ID_ALUNO = @idAluno";


                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@idAluno", idAluno);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // PASSO 3: Gerenciar a exibição
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView3.DataSource = dt;
                        dataGridView3.Visible = true;
                        LblSemCurso.Visible = false;

                        dataGridView3.Columns["ID_CURSO"].Visible = false;
                        dataGridView3.Columns["NOME_CURSO"].HeaderText = "CURSO";
                        dataGridView3.Columns["CARGA_HORARIA"].HeaderText = "CARGA HORÁRIA";
                        dataGridView3.Columns["NOME_PROFESSOR"].HeaderText = "PROFESSOR";
                    }
                    else
                    {
                        dataGridView3.Visible = false;
                        LblSemCurso.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar cursos: " + ex.Message);
                }
            }
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Garante que o clique não foi no cabeçalho
            if (e.RowIndex < 0) return;

            try
            {
                // 1. Obtém o ID do curso da linha clicada
                int idCursoSelecionado = Convert.ToInt32(
                    dataGridView3.Rows[e.RowIndex].Cells["ID_CURSO"].Value
                );

                string nomeCurso = dataGridView3.Rows[e.RowIndex].Cells["NOME_CURSO"].Value.ToString();

                // 2. Cria e exibe o novo UserControl de Alunos

                // **IMPORTANTE**: Substitua 'VisualizarAlunosControl' pelo nome do seu UserControl
                // que mostra a lista de alunos. Você precisa passar o ID_CURSO para ele.

                // VisualizarAlunosControl alunosControl = new VisualizarAlunosControl(idCursoSelecionado);

                // **Placeholder para a navegação**
                MessageBox.Show($"Você selecionou o curso: {nomeCurso} (ID: {idCursoSelecionado}).\n" +
                                "Próxima ação: Abrir tela de alunos.");

                // Lógica de navegação:
                // Exemplo, se o UserControl estiver em um Form principal chamado MainForm:
                // ((MainForm)this.ParentForm).TrocarTela(alunosControl);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do curso selecionado: " + ex.Message);
            }
        }
    }
}
