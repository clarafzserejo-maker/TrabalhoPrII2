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
        private DataTable dtCursos = new DataTable();

        public VerCursosAlunoUserControl()
        {
            InitializeComponent();

            // Permite que a linha inteira seja selecionada e clicável
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.ReadOnly = true; // Apenas visualização

            // Adiciona o evento para lidar com o clique na linha
            dataGridView3.CellDoubleClick += dataGridView3_CellDoubleClick;

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
                        // Exiba mensagem de erro e saia.
                        MessageBox.Show("Erro: Aluno logado não encontrado na base de dados.");
                        return;
                    }
                    string idAluno = idAlunoPK.ToString();

                    // PASSO 2: Buscar os cursos
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

                    // Preenche a variável de classe com os dados brutos
                    dtCursos.Clear();
                    da.Fill(dtCursos);

                    // PASSO 3: Gerenciar a exibição
                    if (dtCursos.Rows.Count > 0)
                    {
                        // Usa a DataView para permitir a filtragem
                        DataView dv = new DataView(dtCursos);
                        dataGridView3.DataSource = dv;

                        dataGridView3.Visible = true;
                        // TORNAR VISÍVEIS: TxbPesquisa2 e pictureBox1
                        TxbPesquisa2.Visible = true; // Torna a TextBox visível
                        pictureBox1.Visible = true;  // Torna a Imagem visível

                        // LblSemCurso deve ser uma Label no seu designer
                        LblSemCurso.Visible = false;

                        // ... (Configuração de colunas) ...
                    }
                    else
                    {
                        dataGridView3.Visible = false;
                        // TORNAR INVISÍVEIS: TxbPesquisa2 e pictureBox1
                        TxbPesquisa2.Visible = false; // Oculta a TextBox
                        pictureBox1.Visible = false;  // Oculta a Imagem

                        // Se ela não existir, remova a linha abaixo
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
                        $"NOME_CURSO LIKE '%{filtro}%' OR NOME_PROFESSOR LIKE '%{filtro}%'";

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

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LblSemCurso_Click(object sender, EventArgs e)
        {

        }
    }
}
