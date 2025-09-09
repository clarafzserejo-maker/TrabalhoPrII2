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
            // 1. Pega o e-mail do usuário
            string emailDestino = TxbForgotEmail.Text;

            // 2. Gera um código aleatório de 6 dígitos
            string codigo = new Random().Next(100000, 999999).ToString();

            try
            {
                // 3. Usa a classe auxiliar para enviar
               RecuperacaoSenhaService.EnviarEmailRedefinicao(emailDestino, codigo);

                MessageBox.Show("Um código foi enviado para o seu e-mail.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void LblForgotEmail_Click(object sender, EventArgs e)
        {

        }
    }
}