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
    public partial class VerBoletimAlunoUserControl : UserControl
    {
        private const string ConnectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno";

        public VerBoletimAlunoUserControl()
        {
            InitializeComponent();
        }

        private void VerBoletimAlunoUserControl_Load(object sender, EventArgs e)
        {
            CarregarBoletimDoAluno();
        }

        private void CarregarBoletimDoAluno()
        {
            // 1. Obter o ID do aluno logado
            string idAluno = SessaoUsuario.IdUsuario;

            if (string.IsNullOrEmpty(idAluno))
            {
                MessageBox.Show("Erro de Sessão: ID do aluno não encontrado. Por favor, faça login novamente.", "Erro de Autorização");
                if (DgvBoletim2 != null) DgvBoletim2.DataSource = null;
                return;
            }

            if (DgvBoletim2 == null)
            {
                MessageBox.Show("Erro de Componente: O DataGridView 'DgvBoletim22' não foi encontrado no User Control.", "Erro de Configuração");
                return;
            }

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();

                    // Consulta SQL para buscar todas as notas, disciplinas e o nome do professor associado
                    string queryBoletim = @"
                        SELECT
                            C.NOME_CURSO AS Disciplina,
                            P.NOME_PROFESSOR AS Professor,
                            N.NOTA_1,
                            N.NOTA_2,
                            N.NOTA_3,
                            N.NOTA_4,
                            -- Calcula a média, tratando as notas como DECIMAL para garantir precisão
                            (N.NOTA_1 + N.NOTA_2 + N.NOTA_3 + N.NOTA_4) / 4.0 AS Media,
                            -- Define o status: APROVADO se Média >= 6.5, REPROVADO caso contrário
                            CASE
                                WHEN (N.NOTA_1 IS NULL OR N.NOTA_2 IS NULL OR N.NOTA_3 IS NULL OR N.NOTA_4 IS NULL) THEN 'Pendente'
                                WHEN (N.NOTA_1 + N.NOTA_2 + N.NOTA_3 + N.NOTA_4) / 4.0 >= 6.5 THEN 'APROVADO'
                                ELSE 'REPROVADO'
                            END AS Status
                        FROM BOLETINS N
                        INNER JOIN CURSOS C ON N.ID_CURSO = C.ID_CURSO
                        -- Join para pegar o nome do professor: assume que cada curso tem um professor principal
                        INNER JOIN CURSOS_PROFESSORES CP ON C.ID_CURSO = CP.ID_CURSO
                        INNER JOIN PROFESSORES P ON CP.ID_PROFESSOR = P.ID_PROFESSOR
                        WHERE N.ID_ALUNO = @idAluno";


                    SqlCommand cmd = new SqlCommand(queryBoletim, con);
                    // O parâmetro do ID do aluno é usado para filtrar o boletim
                    cmd.Parameters.Add("@idAluno", SqlDbType.NVarChar, 50).Value = idAluno;

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dtBoletim = new DataTable();
                    dtBoletim.Load(reader);

                    DataGridViewStyleHelper.AplicarEstiloPadrao(DgvBoletim2);

                    // Carrega os dados no DataGridView
                    DgvBoletim2.DataSource = dtBoletim;



                    // Opcional: Ajusta a formatação da coluna de Média para exibir apenas uma casa decimal
                    if (DgvBoletim2.Columns.Contains("Media"))
                    {
                        DgvBoletim2.Columns["Media"].DefaultCellStyle.Format = "N1";
                    }

                    if (dtBoletim.Rows.Count == 0)
                    {
                        MessageBox.Show("Você não possui notas registradas em nenhuma disciplina.", "Informação");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar o boletim: " + ex.Message, "Erro de Banco de Dados");
                }
            }
        }
    }
}