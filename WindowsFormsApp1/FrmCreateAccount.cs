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
    public partial class FrmCreateAccount : Form
    {
        public FrmCreateAccount()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxbUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblCreateEmail_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            string username = TxbCreateUser.Text;
            string email = TxbEmail.Text;
            string password = TxbCreatePassword.Text;

            

            string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno";

            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();

                    string sql = "INSERT INTO CONTAS (ID_USER, EMAIL, SENHA) VALUES (@username, @email, @password)";

                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Conta criada com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Erro ao criar conta.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao conectar/inserir no banco: " + ex.Message);
            }

            FrmLogin login = new FrmLogin();
            this.Visible = false;
            login.ShowDialog();
            this.Visible = true;
        }

        private void PickBack_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            this.Visible = false;
            login.ShowDialog();
            this.Visible = true;
        }
    }
}
