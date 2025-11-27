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
        private DataTable dtCursos = new DataTable();
        public MeusCursosControl()
        {
            InitializeComponent();

            // Permite que a linha inteira seja selecionada e clicável
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.ReadOnly = true; // Apenas visualização

            // Adiciona o evento para lidar com o clique na linha
            dataGridView2.CellDoubleClick += dataGridView2_CellDoubleClick;

            this.TxbPesquisa4.TextChanged += TxbPesquisa4_TextChanged;
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

                    // PASSO 2: Buscar os cursos
                    string query = @"
                        SELECT 
                            C.ID_CURSO,      
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

                    // Preenche a variável de classe com os dados brutos
                    dtCursos.Clear();
                    da.Fill(dtCursos);

                    DataGridViewStyleHelper.AplicarEstiloPadrao(dataGridView2);

                    // PASSO 3: Gerenciar a exibição
                    if (dtCursos.Rows.Count > 0)
                    {
                        // Usa a DataView para permitir a filtragem
                        DataView dv = new DataView(dtCursos);
                        dataGridView2.DataSource = dv;

                        dataGridView2.Visible = true;
                        // Assumindo que LblSemCurso existe, caso contrário, remova.
                        LblSemCurso.Visible = false;

                        // Oculta o ID para o usuário, mas o mantém na grid para uso no clique
                        dataGridView2.Columns["ID_CURSO"].Visible = false;

                        dataGridView2.Columns["NOME_CURSO"].HeaderText = "CURSO";
                        dataGridView2.Columns["CARGA_HORARIA"].HeaderText = "CARGA HORÁRIA";
                        // TORNAR VISÍVEIS: TxbPesquisa2 e pictureBox1
                        TxbPesquisa4.Visible = true; // Torna a TextBox visível
                        pictureBox1.Visible = true;  // Torna a Imagem visível

                        // LblSemCurso deve ser uma Label no seu designer
                        LblSemCurso.Visible = false;

                    }
                    else
                    {
                        dataGridView2.Visible = false;
                        // TORNAR INVISÍVEIS: TxbPesquisa2 e pictureBox1
                        TxbPesquisa4.Visible = false; // Oculta a TextBox
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

        // =========================================================================
        // EVENTO DE CLIQUE (DUPLO CLIQUE)
        // =========================================================================
           private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Garante que o clique não foi no cabeçalho
            if (e.RowIndex < 0) return;

            try
            {
                // 1. Obtém o ID do curso e o nome da linha clicada
                int idCursoSelecionado = Convert.ToInt32(
                    dataGridView2.Rows[e.RowIndex].Cells["ID_CURSO"].Value
                );

                string nomeCurso = dataGridView2.Rows[e.RowIndex].Cells["NOME_CURSO"].Value.ToString();

                // ==================================================================
                // PASSO 2: CRIAR E EXIBIR O NOVO USERCONTROL (LISTA DE ALUNOS)
                // ==================================================================

                // NOTA: Para este código funcionar, você precisa ter:
                // 1. Uma classe VisualizarAlunosControl que aceita o ID_CURSO no construtor.
                // 2. Um método de navegação no seu Formulário Principal (ParentForm).

                // 1. Instancia o novo controle, passando o ID_CURSO
                // Substitua VisualizarAlunosControl pelo nome correto se for diferente.
                VisualizarAlunosUserControl alunosControl = new VisualizarAlunosUserControl(idCursoSelecionado, nomeCurso);

                // 2. Chama a navegação no Form Principal (assumindo que ele tem um método 'TrocarTela')
                // Se você estiver usando um Panel no Form Principal, a lógica é assim:

                if (this.Parent is Panel parentPanel)
                {
                    // Limpa o painel e adiciona o novo controle
                    parentPanel.Controls.Clear();
                    parentPanel.Controls.Add(alunosControl);
                    alunosControl.Dock = DockStyle.Fill;
                }
                else
                {
                    // Se a navegação for feita por um Form principal (ex: MainForm)
                    // Você pode precisar de uma referência ao Form principal ou um evento.
                    MessageBox.Show($"Navegação pendente. Carregar Alunos do Curso: {nomeCurso} (ID: {idCursoSelecionado}).");
                }
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

        private void TxbPesquisa4_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltroPesquisa();
        }

        private void AplicarFiltroPesquisa()
        {
            string filtro = TxbPesquisa4.Text.Trim();

            // Certifica-se de que estamos trabalhando com uma DataView
            if (dataGridView2.DataSource is DataView dv)
            {
                if (string.IsNullOrEmpty(filtro))
                {
                    // Se a pesquisa estiver vazia, remove o filtro
                    dv.RowFilter = string.Empty;
                }
                else
                {
                    // Cria a expressão de filtro para buscar na coluna NOME_CURSO OU CARGA_HORARIA
                    // Carga horária é tratada como string no LIKE para permitir busca parcial (ex: buscar '100' em '1000')
                    string expressaoFiltro =
                        $"NOME_CURSO LIKE '%{filtro}%' OR CONVERT(CARGA_HORARIA, 'System.String') LIKE '%{filtro}%'";

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
    }
}
