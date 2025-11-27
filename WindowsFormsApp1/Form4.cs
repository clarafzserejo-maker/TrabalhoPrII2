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
using ProjetoProg;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        private string emailUsuario;

        public Form4(string email)
        {
            InitializeComponent();
            this.emailUsuario = email;

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void LblChangePassword_Click(object sender, EventArgs e)
        {

        }

        private string GetSenhaAtualDoUsuario(string email)
        {
            string senha = null;
            using (SqlConnection con = new SqlConnection("Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno"))
            {
                con.Open();

                string query = @"
            SELECT SENHA
            FROM ALUNOS
            WHERE EMAIL_ALUNO = @Email

            UNION

            SELECT SENHA
            FROM PROFESSORES
            WHERE EMAIL_PROFESSOR = @Email";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Email", email);

                object result = cmd.ExecuteScalar();
                if (result != null)
                    senha = result.ToString();
            }

            return senha;
        }

        private bool AtualizarSenhaUsuario(string email, string novaSenha)
        {
            using (SqlConnection con = new SqlConnection("Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno"))
            {
                con.Open();

                string updateAluno = @"
            UPDATE ALUNOS
            SET SENHA = @NovaSenha
            WHERE EMAIL_ALUNO = @Email";

                SqlCommand cmdAluno = new SqlCommand(updateAluno, con);
                cmdAluno.Parameters.AddWithValue("@NovaSenha", novaSenha);
                cmdAluno.Parameters.AddWithValue("@Email", email);

                int rowsAluno = cmdAluno.ExecuteNonQuery();

                if (rowsAluno > 0)
                    return true;

                string updateProf = @"
            UPDATE PROFESSORES
            SET SENHA = @NovaSenha
            WHERE EMAIL_PROFESSOR = @Email";

                SqlCommand cmdProf = new SqlCommand(updateProf, con);
                cmdProf.Parameters.AddWithValue("@NovaSenha", novaSenha);
                cmdProf.Parameters.AddWithValue("@Email", email);

                int rowsProf = cmdProf.ExecuteNonQuery();

                return rowsProf > 0;
            }
        }


        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            string novaSenha = TxbChangePassword.Text;
            string confirmarSenha = TxbChangePassword2.Text;

            if (string.IsNullOrEmpty(novaSenha) || string.IsNullOrEmpty(confirmarSenha))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            if (novaSenha != confirmarSenha)
            {
                MessageBox.Show("As senhas não coincidem.");
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno"))
            {
                con.Open();

                // Verifica se é aluno
                string sqlAluno = "SELECT ID_ALUNO, SENHA_ALUNO FROM ALUNOS WHERE EMAIL_ALUNO = @EMAIL";
                SqlCommand cmdAluno = new SqlCommand(sqlAluno, con);
                cmdAluno.Parameters.AddWithValue("@EMAIL", emailUsuario);

                using (SqlDataReader reader = cmdAluno.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string senhaAtual = reader["SENHA_ALUNO"].ToString();
                        string idAluno = reader["ID_ALUNO"].ToString();

                        // Verifica se a nova senha é igual à antiga
                        if (senhaAtual == novaSenha)
                        {
                            MessageBox.Show("A nova senha não pode ser igual à senha antiga.");
                            return;
                        }

                        reader.Close();

                        // Atualiza senha do aluno
                        string update = "UPDATE ALUNOS SET SENHA_ALUNO = @SENHA WHERE ID_ALUNO = @ID";
                        SqlCommand cmdUpdate = new SqlCommand(update, con);
                        cmdUpdate.Parameters.AddWithValue("@SENHA", novaSenha);
                        cmdUpdate.Parameters.AddWithValue("@ID", idAluno);
                        cmdUpdate.ExecuteNonQuery();

                        MessageBox.Show("Senha atualizada com sucesso!");
                        Btn login = new Btn();
                        this.Visible = false;
                        login.ShowDialog();
                        this.Visible = true;
                        return;
                    }
                }

                // Se não for aluno, verifica professor
                string sqlProf = "SELECT ID_PROFESSOR, SENHA_PROFESSOR FROM PROFESSORES WHERE EMAIL_PROFESSOR = @EMAIL";
                SqlCommand cmdProf = new SqlCommand(sqlProf, con);
                cmdProf.Parameters.AddWithValue("@EMAIL", emailUsuario);

                using (SqlDataReader reader = cmdProf.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string senhaAtual = reader["SENHA_PROFESSOR"].ToString();
                        string idProf = reader["ID_PROFESSOR"].ToString();

                        // Verifica se a nova senha é igual à antiga
                        if (senhaAtual == novaSenha)
                        {
                            MessageBox.Show("A nova senha não pode ser igual à senha antiga.");
                            return;
                        }

                        reader.Close();

                        // Atualiza senha do professor
                        string update = "UPDATE PROFESSORES SET SENHA = @SENHA WHERE ID_PROFESSOR = @ID";
                        SqlCommand cmdUpdate = new SqlCommand(update, con);
                        cmdUpdate.Parameters.AddWithValue("@SENHA", novaSenha);
                        cmdUpdate.Parameters.AddWithValue("@ID", idProf);
                        cmdUpdate.ExecuteNonQuery();

                        MessageBox.Show("Senha atualizada com sucesso!");
                        Btn login = new Btn();
                        this.Visible = false;
                        login.ShowDialog();
                        this.Visible = true;
                        return;
                    }
                }

                // Se chegou aqui, usuário não encontrado
                MessageBox.Show("Erro ao atualizar senha. Usuário não encontrado.");
            }
        }

        private void TxbChangePassword_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
