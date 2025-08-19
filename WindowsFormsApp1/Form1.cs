using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ProjetoProg
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            try
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                MessageBox.Show("Connection Open !");
                cnn.Close();
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n" +
                "Verifique os dados informados" + erro);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PicBackgroundLogin_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.LblUser = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxbUser = new System.Windows.Forms.TextBox();
            this.TxbPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LblCreateAccount = new System.Windows.Forms.Label();
            this.LinkLblCreateAccount = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(222)))));
            this.LblUser.Font = new System.Drawing.Font("Noto Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblUser.Location = new System.Drawing.Point(754, 535);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(140, 44);
            this.LblUser.TabIndex = 1;
            this.LblUser.Text = "Usuário:";
            this.LblUser.Click += new System.EventHandler(this.LblUser_Click);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(222)))));
            this.LblPassword.Font = new System.Drawing.Font("Noto Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(755, 625);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(116, 44);
            this.LblPassword.TabIndex = 2;
            this.LblPassword.Text = "Senha:";
            this.LblPassword.Click += new System.EventHandler(this.LblPassword_Click);
            // 
            // TxbUser
            // 
            this.TxbUser.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.TxbUser.Font = new System.Drawing.Font("Noto Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbUser.Location = new System.Drawing.Point(762, 582);
            this.TxbUser.Multiline = true;
            this.TxbUser.Name = "TxbUser";
            this.TxbUser.Size = new System.Drawing.Size(380, 40);
            this.TxbUser.TabIndex = 3;
            this.TxbUser.TextChanged += new System.EventHandler(this.TxbUser_TextChanged);
            // 
            // TxbPassword
            // 
            this.TxbPassword.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.TxbPassword.Font = new System.Drawing.Font("Noto Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbPassword.Location = new System.Drawing.Point(763, 672);
            this.TxbPassword.Multiline = true;
            this.TxbPassword.Name = "TxbPassword";
            this.TxbPassword.PasswordChar = '•';
            this.TxbPassword.Size = new System.Drawing.Size(380, 40);
            this.TxbPassword.TabIndex = 4;
            this.TxbPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.Font = new System.Drawing.Font("Noto Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(891, 727);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(141, 54);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "Entrar";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LblCreateAccount
            // 
            this.LblCreateAccount.AutoSize = true;
            this.LblCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(222)))));
            this.LblCreateAccount.Font = new System.Drawing.Font("Noto Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCreateAccount.Location = new System.Drawing.Point(836, 784);
            this.LblCreateAccount.Name = "LblCreateAccount";
            this.LblCreateAccount.Size = new System.Drawing.Size(250, 88);
            this.LblCreateAccount.TabIndex = 6;
            this.LblCreateAccount.Text = "Não tem conta?\r\nCrie uma   ......";
            this.LblCreateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblCreateAccount.Click += new System.EventHandler(this.LblCreateAccount_Click);
            // 
            // LinkLblCreateAccount
            // 
            this.LinkLblCreateAccount.AutoSize = true;
            this.LinkLblCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(222)))));
            this.LinkLblCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkLblCreateAccount.Font = new System.Drawing.Font("Noto Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLblCreateAccount.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LinkLblCreateAccount.Location = new System.Drawing.Point(991, 828);
            this.LinkLblCreateAccount.Name = "LinkLblCreateAccount";
            this.LinkLblCreateAccount.Size = new System.Drawing.Size(83, 44);
            this.LinkLblCreateAccount.TabIndex = 7;
            this.LinkLblCreateAccount.TabStop = true;
            this.LinkLblCreateAccount.Text = "aqui";
            this.LinkLblCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblCreateAccount_LinkClicked);
            // 
            // FrmLogin
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.LinkLblCreateAccount);
            this.Controls.Add(this.LblCreateAccount);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxbPassword);
            this.Controls.Add(this.TxbUser);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUser);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void LblUser_Click(object sender, EventArgs e)
        {

        }

        private void LblPassword_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string usuario = TxbUser.Text.Trim();
            string senha = TxbPassword.Text.Trim();

            string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno";

            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();

                    string sql = "SELECT COUNT(1) FROM CONTAS WHERE ID_USER = @usuario AND SENHA = @senha";

                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        int count = (int)cmd.ExecuteScalar();

                        if (count == 1)
                        {
                            MessageBox.Show("Login feito com sucesso!");

                            FrmDisciplinas disciplinas = new FrmDisciplinas();
                            this.Visible = false;
                            disciplinas.ShowDialog();
                            this.Visible = true;

                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha incorretos.",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar no banco: " + ex.Message);
            }

        }

        private void PicLogin_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void TxbUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void LinkLblCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCreateAccount criarconta = new FrmCreateAccount();
            this.Visible = false;
            criarconta.ShowDialog();
            this.Visible = true;
        }

        private void LblCreateAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
