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
    public partial class VisualizarAgendaUserControl : UserControl
    {
        public VisualizarAgendaUserControl()
        {
            InitializeComponent();
        }

        // VisualizarAgendaUserControl.cs

        // Remova este método: private void CalAgenda_DateSelected(object sender, DateRangeEventArgs e)
        // Ou simplesmente remova o código dentro dele, se você não quiser mais que ele filtre.

        private void VisualizarAgendaUserControl_Load(object sender, EventArgs e)
        {
            // Ao carregar, chama a função para mostrar TUDO
            CarregarTodasAulasAgendadas();
        }

        // Opcional: Se quiser usar o MonthCalendar para selecionar a data, mas não filtrar o DataGridView:
        private void CalAgenda_DateSelected(object sender, DateRangeEventArgs e)
        {
            // Aqui você pode, por exemplo, mudar o título do DataGridView para
            // "Todas as Aulas (Dia Selecionado: XXXXX)" se desejar.
        }


        // NOVO MÉTODO (ou o método 'CarregarAulasAgendadas' modificado)
        private void CarregarTodasAulasAgendadas()
        {
            // Obtém o ID do professor logado
            string idProfessorStr = SessaoUsuario.IdUsuario;
            if (string.IsNullOrEmpty(idProfessorStr))
            {
                MessageBox.Show("Erro de sessão. Faça login novamente.", "Erro");
                DgvAgenda.DataSource = null;
                return;
            }

            string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Consulta que traz as aulas do professor logado, SEM FILTRO DE DATA.
                    string query = @"
                SELECT 
                    A.DATA_HORA AS DATA_HORA_COMPLETA, -- Manter a data/hora completa para ordenação
                    CONVERT(VARCHAR(10), A.DATA_HORA, 103) AS DATA, -- Formato dd/mm/yyyy
                    CONVERT(VARCHAR(5), A.DATA_HORA, 108) AS HORA,  -- Formato HH:mm
                    C.NOME_CURSO AS CURSO,
                    L.NOME_ALUNO AS ALUNO
                FROM 
                    AULAS_AGENDADAS A
                INNER JOIN CURSOS C ON A.ID_CURSO = C.ID_CURSO
                INNER JOIN ALUNOS L ON A.ID_ALUNO = L.ID_ALUNO
                WHERE 
                    A.ID_PROFESSOR = @idProfessor
                ORDER BY
                    A.DATA_HORA ASC"; // Ordena da mais antiga para a mais recente

                    SqlCommand cmd = new SqlCommand(query, con);

                    // Parâmetro de filtro (apenas pelo professor)
                    cmd.Parameters.AddWithValue("@idProfessor", idProfessorStr);

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dtAulas = new DataTable();
                    dtAulas.Load(reader);

                    DgvAgenda.DataSource = dtAulas;

                    // Ajusta o DataGridView
                    if (dtAulas.Rows.Count > 0)
                    {
                        // Esconder a coluna de ordenação original, se desejar
                        DgvAgenda.Columns["DATA_HORA_COMPLETA"].Visible = false;

                        DgvAgenda.Columns["DATA"].Width = 90;
                        DgvAgenda.Columns["HORA"].Width = 60;
                        DgvAgenda.Columns["CURSO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        DgvAgenda.Columns["ALUNO"].Width = 150;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar todas as aulas: " + ex.Message, "Erro de Banco de Dados");
                }
            }
        }
    }
}
