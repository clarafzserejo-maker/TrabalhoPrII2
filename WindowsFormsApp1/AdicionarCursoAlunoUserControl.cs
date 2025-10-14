using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjetoProg.Btn;

namespace WindowsFormsApp1
{
    public partial class AdicionarCursoAlunoUserControl : UserControl
    {
        string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno";

        public AdicionarCursoAlunoUserControl()
        {
            InitializeComponent();
            CarregarCursos2();
        }

        private void CarregarCursos2()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // A query faz uma junção (JOIN) para criar uma linha para CADA par (Curso, Professor).
                string query = @"
            SELECT 
                CP.ID_CURSO,            
                C.NOME_CURSO,          
                C.CARGA_HORARIA,      
                P.NOME_PROFESSOR AS NOME_PROFESSOR, 
                        P.ID_PROFESSOR
            FROM
                        CURSOS_PROFESSORES CP    
                    INNER JOIN
                        CURSOS C ON CP.ID_CURSO = C.ID_CURSO
                    INNER JOIN
                        PROFESSORES P ON CP.ID_PROFESSOR = P.ID_PROFESSOR
                    ORDER BY
                        C.NOME_CURSO, P.NOME_PROFESSOR"; // Ordena para agrupar as mesmas disciplinas
        

        SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                // Configuração dos cabeçalhos

                // Colunas essenciais para o usuário
                dataGridView1.Columns["NOME_CURSO"].HeaderText = "CURSO";
                dataGridView1.Columns["CARGA_HORARIA"].HeaderText = "CARGA HORÁRIA";
                dataGridView1.Columns["NOME_PROFESSOR"].HeaderText = "PROFESSOR"; // O nome da turma

                // Colunas essenciais para a Matrícula, mas ocultas
                dataGridView1.Columns["ID_CURSO"].Visible = false;

                // Ocultar o ID do Professor, mas mantê-lo na Grid caso você precise
                // dele para uma lógica futura (ex: verificar se a turma tem vagas)
                dataGridView1.Columns["ID_PROFESSOR"].Visible = false;

                // Adicionar uma coluna de "Turma" se desejar, concatenando NOME_CURSO e NOME_PROFESSOR
                // (Isso seria feito no código C# se preferir)
            }
        }



        private void AdicionarCursoAlunoUserControl_Load(object sender, EventArgs e)
        {

        }

        private void BtnNewCourse_Click(object sender, EventArgs e)
        {
            
            // Acessar a sessão do Aluno logado (Ajuste conforme sua variável de sessão)
            string emailAluno = SessaoUsuario.Email;
            int idCursoSelecionado;
            object idAlunoPK = null;

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um curso na lista para se matricular.", "Erro de Seleção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            idCursoSelecionado = Convert.ToInt32(selectedRow.Cells["ID_CURSO"].Value);
            string nomeCurso = selectedRow.Cells["NOME_CURSO"].Value.ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // PASSO 1: BUSCAR O ID_ALUNO
                // Assumindo que sua tabela de Alunos se chame ALUNOS e use EMAIL_ALUNO
                SqlCommand getIdCmd = new SqlCommand(
                    "SELECT ID_ALUNO FROM ALUNOS WHERE EMAIL_ALUNO = @email", conn);
                getIdCmd.Parameters.AddWithValue("@email", emailAluno);

                idAlunoPK = getIdCmd.ExecuteScalar();

                if (idAlunoPK == null)
                {
                    MessageBox.Show("Erro: Aluno logado não encontrado na base de dados.", "Erro de Sessão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // PASSO 2: VERIFICAR SE O ALUNO JÁ ESTÁ MATRICULADO
                SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM ALUNOS_CURSOS WHERE ID_ALUNO = @alunoId AND ID_CURSO = @cursoId", conn);
                checkCmd.Parameters.AddWithValue("@alunoId", idAlunoPK);
                checkCmd.Parameters.AddWithValue("@cursoId", idCursoSelecionado);

                int jaMatriculado = (int)checkCmd.ExecuteScalar();

                if (jaMatriculado > 0)
                {
                    MessageBox.Show($"Você já está matriculado no curso '{nomeCurso}'.", "Matrícula Existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // PASSO 3: INSERIR A MATRÍCULA
                SqlCommand insertCmd = new SqlCommand(
                    "INSERT INTO ALUNOS_CURSOS (ID_ALUNO, ID_CURSO) VALUES (@alunoId, @cursoId)", conn);
                insertCmd.Parameters.AddWithValue("@alunoId", idAlunoPK);
                insertCmd.Parameters.AddWithValue("@cursoId", idCursoSelecionado);
                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Matrícula realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    }
