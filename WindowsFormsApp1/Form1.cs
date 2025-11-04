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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjetoProg
{


    public partial class Btn : Form
    {
        public Btn()
        {
            InitializeComponent();
            try
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno";
                cnn = new SqlConnection(connetionString);
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n" +
                "Verifique os dados informados" + erro);
            }
        }
        public static class SessaoUsuario
        {
            public static string IdUsuario { get; set; }
            public static string Nome { get; set; }
            public static string Email { get; set; }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Btn));
            this.LblUser = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxbUser = new System.Windows.Forms.TextBox();
            this.TxbPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LblCreateAccount = new System.Windows.Forms.Label();
            this.LinkLblCreateAccount = new System.Windows.Forms.LinkLabel();
            this.LinkLblForgotAccount = new System.Windows.Forms.LinkLabel();
            this.CheckBoxTeacher = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(222)))));
            this.LblUser.Font = new System.Drawing.Font("Swis721 Blk BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(199)))));
            this.LblUser.Location = new System.Drawing.Point(288, 393);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(149, 35);
            this.LblUser.TabIndex = 1;
            this.LblUser.Text = "Usuário:";
            this.LblUser.Click += new System.EventHandler(this.LblUser_Click);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(222)))));
            this.LblPassword.Font = new System.Drawing.Font("Swis721 Blk BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(199)))));
            this.LblPassword.Location = new System.Drawing.Point(288, 501);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(125, 35);
            this.LblPassword.TabIndex = 2;
            this.LblPassword.Text = "Senha:";
            this.LblPassword.Click += new System.EventHandler(this.LblPassword_Click);
            // 
            // TxbUser
            // 
            this.TxbUser.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.TxbUser.Font = new System.Drawing.Font("Microsoft JhengHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbUser.Location = new System.Drawing.Point(294, 431);
            this.TxbUser.Multiline = true;
            this.TxbUser.Name = "TxbUser";
            this.TxbUser.Size = new System.Drawing.Size(546, 47);
            this.TxbUser.TabIndex = 3;
            this.TxbUser.TextChanged += new System.EventHandler(this.TxbUser_TextChanged);
            // 
            // TxbPassword
            // 
            this.TxbPassword.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.TxbPassword.Font = new System.Drawing.Font("Microsoft JhengHei", 21.75F);
            this.TxbPassword.Location = new System.Drawing.Point(294, 539);
            this.TxbPassword.Multiline = true;
            this.TxbPassword.Name = "TxbPassword";
            this.TxbPassword.PasswordChar = '•';
            this.TxbPassword.Size = new System.Drawing.Size(546, 47);
            this.TxbPassword.TabIndex = 4;
            this.TxbPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.Font = new System.Drawing.Font("Swis721 Blk BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(473, 713);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(200, 57);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "ENTRAR";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LblCreateAccount
            // 
            this.LblCreateAccount.AutoSize = true;
            this.LblCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(222)))));
            this.LblCreateAccount.Font = new System.Drawing.Font("Swis721 Blk BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(199)))));
            this.LblCreateAccount.Location = new System.Drawing.Point(472, 791);
            this.LblCreateAccount.Name = "LblCreateAccount";
            this.LblCreateAccount.Size = new System.Drawing.Size(202, 48);
            this.LblCreateAccount.TabIndex = 6;
            this.LblCreateAccount.Text = "Clique aqui para \r\ncriar uma conta\r\n";
            this.LblCreateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblCreateAccount.Click += new System.EventHandler(this.LblCreateAccount_Click);
            // 
            // LinkLblCreateAccount
            // 
            this.LinkLblCreateAccount.AutoSize = true;
            this.LinkLblCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(222)))));
            this.LinkLblCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkLblCreateAccount.Font = new System.Drawing.Font("Swis721 Blk BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLblCreateAccount.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.LinkLblCreateAccount.Location = new System.Drawing.Point(549, 791);
            this.LinkLblCreateAccount.Name = "LinkLblCreateAccount";
            this.LinkLblCreateAccount.Size = new System.Drawing.Size(59, 24);
            this.LinkLblCreateAccount.TabIndex = 7;
            this.LinkLblCreateAccount.TabStop = true;
            this.LinkLblCreateAccount.Text = "aqui";
            this.LinkLblCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblCreateAccount_LinkClicked);
            // 
            // LinkLblForgotAccount
            // 
            this.LinkLblForgotAccount.AutoSize = true;
            this.LinkLblForgotAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(222)))));
            this.LinkLblForgotAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkLblForgotAccount.Font = new System.Drawing.Font("Swis721 Blk BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLblForgotAccount.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.LinkLblForgotAccount.Location = new System.Drawing.Point(290, 591);
            this.LinkLblForgotAccount.Name = "LinkLblForgotAccount";
            this.LinkLblForgotAccount.Size = new System.Drawing.Size(247, 24);
            this.LinkLblForgotAccount.TabIndex = 8;
            this.LinkLblForgotAccount.TabStop = true;
            this.LinkLblForgotAccount.Text = "Esqueci minha senha";
            this.LinkLblForgotAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblForgotAccount_LinkClicked);
            // 
            // CheckBoxTeacher
            // 
            this.CheckBoxTeacher.AutoSize = true;
            this.CheckBoxTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(222)))));
            this.CheckBoxTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxTeacher.Font = new System.Drawing.Font("Swis721 Blk BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.CheckBoxTeacher.Location = new System.Drawing.Point(294, 625);
            this.CheckBoxTeacher.Name = "CheckBoxTeacher";
            this.CheckBoxTeacher.Size = new System.Drawing.Size(272, 28);
            this.CheckBoxTeacher.TabIndex = 12;
            this.CheckBoxTeacher.Text = "Entrar como educador";
            this.CheckBoxTeacher.UseVisualStyleBackColor = false;
            this.CheckBoxTeacher.CheckedChanged += new System.EventHandler(this.CheckBoxTeacher_CheckedChanged);
            // 
            // Btn
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.CheckBoxTeacher);
            this.Controls.Add(this.LinkLblForgotAccount);
            this.Controls.Add(this.LinkLblCreateAccount);
            this.Controls.Add(this.LblCreateAccount);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxbPassword);
            this.Controls.Add(this.TxbUser);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUser);
            this.Name = "Btn";
            this.Text = "ENTRAR";
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

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
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

                    bool isProfessor = CheckBoxTeacher.Checked;

                    string tabela = isProfessor ? "PROFESSORES" : "ALUNOS";
                    string colunaId = isProfessor ? "ID_PROFESSOR" : "ID_ALUNO";
                    string colunaSenha = isProfessor ? "SENHA_PROFESSOR" : "SENHA_ALUNO";
                    string colunaNome = isProfessor ? "NOME_PROFESSOR" : "NOME_ALUNO";
                    string colunaEmail = isProfessor ? "EMAIL_PROFESSOR" : "EMAIL_ALUNO";

                    // 1. Verifica se login está correto
                    string sqlLogin = $@"
                SELECT COUNT(1) 
                FROM {tabela} 
                WHERE {colunaId} = @usuario AND {colunaSenha} = @senha
            ";

                    using (SqlCommand cmd = new SqlCommand(sqlLogin, cnn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        int count = (int)cmd.ExecuteScalar();

                        if (count != 1)
                        {
                            MessageBox.Show("Usuário ou senha incorretos.",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // 2. Busca nome e email do usuário logado
                    string sqlDados = $@"
    SELECT {colunaId}, {colunaNome}, {colunaEmail} -- 3 COLUNAS
    FROM {tabela}
    WHERE {colunaId} = @usuario
";

                    using (SqlCommand cmdDados = new SqlCommand(sqlDados, cnn))
                    {
                        cmdDados.Parameters.AddWithValue("@usuario", usuario);

                        using (SqlDataReader reader = cmdDados.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // O ID_PROFESSOR/ID_ALUNO deve ser SALVO aqui!
                                SessaoUsuario.IdUsuario = reader[colunaId].ToString();
                                SessaoUsuario.Nome = reader[colunaNome].ToString();
                                SessaoUsuario.Email = reader[colunaEmail].ToString();
                            }
                        }
                    }

                    // 3. Abre a tela correta após login
                    MessageBox.Show("Login feito com sucesso!");

                    this.Visible = false;

                    if (isProfessor)
                    {
                        SegundaProf perfilProf = new SegundaProf();
                        perfilProf.ShowDialog();
                    }
                    else
                    {
                        SegundaAluno perfilAluno = new SegundaAluno();
                        perfilAluno.ShowDialog();
                    }

                    this.Visible = true;
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

        private void LinkLblForgotAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 mudarsenha = new Form3();
            this.Visible = false;
            mudarsenha.ShowDialog();
           
        }

        private void CheckBoxTeacher_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
