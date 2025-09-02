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
            string name = TxbCreateName.Text;
            bool isProfessor = CheckBoxTeacher2.Checked;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Não podem existir campos vazios!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno";

            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();

                    // Verifica se o nome de usuário OU o email já existem
                    string queryVerificar = @"SELECT COUNT(*) FROM (    SELECT ID_ALUNO AS ID, EMAIL FROM ALUNOS WHERE ID_ALUNO = @username OR EMAIL = @email
    UNION ALL
    SELECT ID_PROFESSOR AS ID, EMAIL FROM PROFESSORES WHERE ID_PROFESSOR = @username OR EMAIL = @email
) AS Usuarios";
                    using (SqlCommand cmdVerificar = new SqlCommand(queryVerificar, cnn))
                    {
                        cmdVerificar.Parameters.AddWithValue("@username", username);
                        cmdVerificar.Parameters.AddWithValue("@email", email);

                        int count = (int)cmdVerificar.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Já existe uma conta com esse nome de usuário ou email.",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Inserir nova conta
                    string sql;
                    if (isProfessor)
                    {
                        sql = "INSERT INTO PROFESSORES (ID_PROFESSOR, NOME, EMAIL, SENHA) VALUES (@username, @name, @email, @password)";
                    }
                    else
                    {
                        sql = "INSERT INTO ALUNOS (ID_ALUNO, NOME, EMAIL, SENHA) VALUES (@username, @name, @email, @password)";
                    }
                    using (SqlCommand cmdInserir = new SqlCommand(sql, cnn))
                    {
                        cmdInserir.Parameters.AddWithValue("@username", username);
                        cmdInserir.Parameters.AddWithValue("@email", email);
                        cmdInserir.Parameters.AddWithValue("@password", password);
                        cmdInserir.Parameters.AddWithValue("@name", name);

                        int linhasAfetadas = cmdInserir.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Conta criada com sucesso!",
                                "Sucesso",
                                MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Erro ao criar conta.",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao conectar/inserir no banco: " + ex.Message);
            }

            Btn login = new Btn();
            this.Visible = false;
            login.ShowDialog();
            this.Visible = true;
        }

        private void PickBack_Click(object sender, EventArgs e)
        {
            Btn login = new Btn();
            this.Visible = false;
            login.ShowDialog();
            this.Visible = true;
        }

        private void PicShow_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmCreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void LblCreateTeacherAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
         
        }
    }
}
