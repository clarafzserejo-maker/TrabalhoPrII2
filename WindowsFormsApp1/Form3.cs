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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void TxbCreateUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void PickBack2_Click(object sender, EventArgs e)
        {
            Btn login = new Btn();
            this.Visible = false;
            login.ShowDialog();
            this.Visible = true;
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            string username = TxbForgotUser.Text.Trim();
            string email = TxbForgotEmail.Text.Trim();
            string password2 = TxbNewPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password2))
            {
                MessageBox.Show("Não podem existir campos vazios!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno;";
            string senhaAtual = null;

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();

                    // 1. Verifica se existe o usuário com o e-mail correspondente
                    string queryVerificar = "SELECT COUNT(*) FROM ALUNOS WHERE ID_ALUNO = @username AND Email = @email";

                    using (SqlCommand cmdVerificar = new SqlCommand(queryVerificar, conexao))
                    {
                        cmdVerificar.Parameters.AddWithValue("@username", username);
                        cmdVerificar.Parameters.AddWithValue("@email", email);

                        int existe = (int)cmdVerificar.ExecuteScalar();

                        if (existe == 0)
                        {
                            MessageBox.Show("Usuário ou e-mail incorretos.",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // 2. Busca a senha atual no banco
                    string querySenha = "SELECT SENHA FROM ALUNOS WHERE ID_ALUNO = @username AND Email = @email";

                    using (SqlCommand cmdSenha = new SqlCommand(querySenha, conexao))
                    {
                        cmdSenha.Parameters.AddWithValue("@username", username);
                        cmdSenha.Parameters.AddWithValue("@email", email);

                        object resultado = cmdSenha.ExecuteScalar();

                        if (resultado != null)
                        {
                            senhaAtual = resultado.ToString();
                        }
                    }

                    // 3. Compara a nova senha com a atual
                    if (senhaAtual == password2)
                    {
                        MessageBox.Show("A nova senha não pode ser igual à senha atual.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 4. Atualiza a senha
                    string queryAtualizar = "UPDATE ALUNOS SET SENHA = @password2 WHERE ID_ALUNO = @username AND EMAIL = @email";

                    using (SqlCommand cmdAtualizar = new SqlCommand(queryAtualizar, conexao))
                    {
                        cmdAtualizar.Parameters.AddWithValue("@password2", password2);
                        cmdAtualizar.Parameters.AddWithValue("@username", username);
                        cmdAtualizar.Parameters.AddWithValue("@email", email);

                        int linhasAfetadas = cmdAtualizar.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Senha atualizada com sucesso!",
                                "Sucesso",
                                MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Erro ao atualizar a senha.",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                // Volta para a tela de login
                Btn login = new Btn();
                this.Visible = false;
                login.ShowDialog();
                this.Visible = true;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}