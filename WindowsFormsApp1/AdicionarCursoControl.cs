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
    public partial class AdicionarCursoControl : UserControl
    {
        string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno";

        public AdicionarCursoControl()
        {
            InitializeComponent();
            CarregarCursos();
        }

        private void CarregarCursos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ID_CURSO, NOME_CURSO, CARGA_HORARIA FROM Cursos";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["ID_CURSO"].HeaderText = "ID";
                dataGridView1.Columns["NOME_CURSO"].HeaderText = "CURSO";
                dataGridView1.Columns["CARGA_HORARIA"].HeaderText = "CARGA HORÁRIA";

            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string nomeCurso = TxbNomeCurso.Text.Trim();
            string cargaHoraria = TxbCargaHoraria.Text.Trim();

            if (nomeCurso == "" || cargaHoraria == "")
            {
                MessageBox.Show("Preencha todos os campos antes de adicionar o curso.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Verifica se já existe curso com esse nome
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM CURSOS WHERE NOME_CURSO = @nome AND CARGA_HORARIA = @carga", conn);
                checkCmd.Parameters.AddWithValue("@nome", nomeCurso);
                checkCmd.Parameters.AddWithValue("@carga", cargaHoraria);

                int existe = (int)checkCmd.ExecuteScalar();

                if (existe > 0)
                {
                    MessageBox.Show("Esse curso já existe no banco de dados.");
                    return;
                }

                // Se não existir, adiciona
                SqlCommand insertCmd = new SqlCommand(
                    "INSERT INTO CURSOS (NOME_CURSO, CARGA_HORARIA) VALUES (@nome, @carga)", conn);
                insertCmd.Parameters.AddWithValue("@nome", nomeCurso);
                insertCmd.Parameters.AddWithValue("@carga", cargaHoraria);
                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Curso adicionado com sucesso!");
            }

            CarregarCursos(); // atualiza o DataGridView
        }

        private void BtnSaveCourse_Click(object sender, EventArgs e)
        {
            string emailProfessor = SessaoUsuario.Email;
            int idCurso;
            object idProfessorPK = null;

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um curso na lista.");
                return;
            }

            // Obtém o ID e o Nome do Curso selecionado para usar na mensagem de erro.
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            idCurso = Convert.ToInt32(selectedRow.Cells["ID_CURSO"].Value);
            string nomeCurso = selectedRow.Cells["NOME_CURSO"].Value.ToString(); // Assumindo que a coluna NOME_CURSO está como "CURSO"

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // =========================================================================
                // PASSO 1: BUSCAR O ID_PROFESSOR (CHAVE PRIMÁRIA/Referenciada) COM BASE NO EMAIL
                // Isso resolve o erro de FOREIGN KEY, pois usa o ID correto para o banco.
                // =========================================================================
                SqlCommand getIdCmd = new SqlCommand(
                    "SELECT ID_PROFESSOR FROM PROFESSORES WHERE EMAIL_PROFESSOR = @email", conn);
                getIdCmd.Parameters.AddWithValue("@email", emailProfessor);

                idProfessorPK = getIdCmd.ExecuteScalar();

                if (idProfessorPK == null)
                {
                    MessageBox.Show("Erro: Professor logado não encontrado na tabela PROFESSORES. Verifique o cadastro.");
                    return;
                }

                // =========================================================================
                // PASSO 2: VERIFICAR VÍNCULO EXISTENTE (Aprimorado)
                // =========================================================================

                // Verifica se o professor já está vinculado a esse curso usando o ID_PROFESSOR
                SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM CURSOS_PROFESSORES WHERE ID_PROFESSOR = @profId AND ID_CURSO = @curso", conn);
                checkCmd.Parameters.AddWithValue("@profId", idProfessorPK); // Usando o ID_PROFESSOR correto
                checkCmd.Parameters.AddWithValue("@curso", idCurso);

                int existe = (int)checkCmd.ExecuteScalar();

                if (existe > 0)
                {
                    // Mensagem personalizada conforme solicitado
                    MessageBox.Show($"Você já está vinculado ao curso '{nomeCurso}' e não pode se vincular novamente.", "Vínculo Existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // =========================================================================
                // PASSO 3: INSERIR O VÍNCULO
                // =========================================================================

                // Insere o vínculo
                SqlCommand insertCmd = new SqlCommand(
                    "INSERT INTO CURSOS_PROFESSORES (ID_PROFESSOR, ID_CURSO) VALUES (@profId, @curso)", conn);
                insertCmd.Parameters.AddWithValue("@profId", idProfessorPK);
                insertCmd.Parameters.AddWithValue("@curso", idCurso);
                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Curso vinculado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LblCargaHoraria_Click(object sender, EventArgs e)
        {

        }
    }
}


