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
    public partial class MeusCursosControl : UserControl
    {
        // Sua string de conexão
        string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno";

        public MeusCursosControl()
        {
            InitializeComponent();

            // Permite que a linha inteira seja selecionada e clicável
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.ReadOnly = true; // Apenas visualização

            // Adiciona o evento para lidar com o clique na linha
            dataGridView2.CellDoubleClick += dataGridView2_CellDoubleClick;
        }

        private void MeusCursosControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                CarregarCursosDoProfessor();
            }
        }

        private void CarregarCursosDoProfessor()
        {
            string emailProfessor = SessaoUsuario.Email;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // PASSO 1: Buscar o ID_PROFESSOR (chave primária)
                    SqlCommand getIdCmd = new SqlCommand(
                        "SELECT ID_PROFESSOR FROM PROFESSORES WHERE EMAIL_PROFESSOR = @email", conn);
                    getIdCmd.Parameters.AddWithValue("@email", emailProfessor);
                    object idProfessorPK = getIdCmd.ExecuteScalar();

                    if (idProfessorPK == null) { /* ... (mensagem de erro) ... */ return; }
                    string idProf = idProfessorPK.ToString();

                    // PASSO 2: Buscar os cursos (Incluindo ID_CURSO, pois ele é necessário para a próxima tela)
                    string query = @"
                    SELECT 
                        C.ID_CURSO,       -- Necessário para buscar os alunos
                        C.NOME_CURSO, 
                        C.CARGA_HORARIA 
                    FROM 
                        Cursos C
                    INNER JOIN 
                        CURSOS_PROFESSORES PC ON C.ID_CURSO = PC.ID_CURSO
                    WHERE 
                        PC.ID_PROFESSOR = @idProf";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@idProf", idProf);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // PASSO 3: Gerenciar a exibição
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView2.DataSource = dt;
                        dataGridView2.Visible = true;
                        LblSemCurso.Visible = false;

                        // Oculta o ID para o usuário, mas o mantém na grid para uso no clique
                        dataGridView2.Columns["ID_CURSO"].Visible = false;

                        dataGridView2.Columns["NOME_CURSO"].HeaderText = "CURSO";
                        dataGridView2.Columns["CARGA_HORARIA"].HeaderText = "CARGA HORÁRIA";
                    }
                    else
                    {
                        dataGridView2.Visible = false;
                        LblSemCurso.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar cursos: " + ex.Message);
                }
            }
        }

        // =========================================================================
        // EVENTO DE CLIQUE (DUPLO CLIQUE)
        // =========================================================================
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Garante que o clique não foi no cabeçalho
            if (e.RowIndex < 0) return;

            try
            {
                // 1. Obtém o ID do curso da linha clicada
                int idCursoSelecionado = Convert.ToInt32(
                    dataGridView2.Rows[e.RowIndex].Cells["ID_CURSO"].Value
                );

                string nomeCurso = dataGridView2.Rows[e.RowIndex].Cells["NOME_CURSO"].Value.ToString();

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
        

        private void LblSemCurso_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
