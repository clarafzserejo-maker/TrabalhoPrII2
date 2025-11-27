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
    public partial class TodosOsAlunosUserControl : UserControl
    {
        string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno";
        private DataTable dtAlunosConsolidado = new DataTable();
        public TodosOsAlunosUserControl()
        {
            InitializeComponent();
            dataGridViewTodosOsAlunos.CellDoubleClick += dataGridViewTodosOsAlunos_CellDoubleClick;
        }

        private void TodosOsAlunosUserControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                CarregarTodosOsAlunos();
            }
        }
        private void CarregarTodosOsAlunos()
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

                    if (idProfessorPK == null)
                    {
                        MessageBox.Show("Erro: Professor logado não encontrado na base de dados.", "Erro de Sessão");
                        return;
                    }
                    string idProfessor = idProfessorPK.ToString();

                    // PASSO 2: Buscar Alunos, Cursos e E-mails associados a este professor
                    // Essa consulta cruza todas as tabelas para obter a lista consolidada de alunos
                    string query = @"
                        SELECT DISTINCT
                            A.NOME_ALUNO,
                            C.NOME_CURSO,
                            A.EMAIL_ALUNO,
                            A.ID_ALUNO
                        FROM
                            ALUNOS A
                        INNER JOIN ALUNOS_CURSOS AC ON A.ID_ALUNO = AC.ID_ALUNO
                        INNER JOIN CURSOS C ON AC.ID_CURSO = C.ID_CURSO
                        INNER JOIN CURSOS_PROFESSORES CP ON C.ID_CURSO = CP.ID_CURSO
                        WHERE 
                            CP.ID_PROFESSOR = @idProfessor
                        ORDER BY
                            A.NOME_ALUNO";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@idProfessor", idProfessor);

                    dtAlunosConsolidado.Clear();
                    da.Fill(dtAlunosConsolidado);

                    DataGridViewStyleHelper.AplicarEstiloPadrao(dataGridViewTodosOsAlunos);

                    // PASSO 3: Gerenciar a exibição
                    if (dtAlunosConsolidado.Rows.Count > 0)
                    {
                        dataGridViewTodosOsAlunos.DataSource = dtAlunosConsolidado;
                        dataGridViewTodosOsAlunos.Visible = true;

                        // Oculta a chave primária e define os cabeçalhos
                        dataGridViewTodosOsAlunos.Columns["ID_ALUNO"].Visible = false;
                        dataGridViewTodosOsAlunos.Columns["NOME_ALUNO"].HeaderText = "NOME DO ALUNO";
                        dataGridViewTodosOsAlunos.Columns["NOME_CURSO"].HeaderText = "CURSO";
                        dataGridViewTodosOsAlunos.Columns["EMAIL_ALUNO"].HeaderText = "E-MAIL";

                        // Se houver um Label "Sem Alunos" na tela, torne-o invisível
                        // LblSemAluno.Visible = false;
                    }
                    else
                    {
                        dataGridViewTodosOsAlunos.Visible = false;
                        MessageBox.Show("Você não possui nenhum curso com alunos associados.", "Informação");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar lista de alunos: " + ex.Message, "Erro de Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
                private void dataGridViewTodosOsAlunos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Exemplo de ação ao clicar duas vezes (ex: Abrir Perfil ou Agendar Aula)
            string nomeAluno = dataGridViewTodosOsAlunos.Rows[e.RowIndex].Cells["NOME_ALUNO"].Value.ToString();
            string emailAluno = dataGridViewTodosOsAlunos.Rows[e.RowIndex].Cells["EMAIL_ALUNO"].Value.ToString();

            MessageBox.Show($"Opções para o aluno: {nomeAluno} ({emailAluno})", "Ação Selecionada");

            // Aqui você chamaria o menu de contexto ou a tela de agendamento/detalhes
        }
    }
        }
   