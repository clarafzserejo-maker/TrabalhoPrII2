using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            FrmDisciplinas disciplinas = new FrmDisciplinas();
            this.Visible = false;
            disciplinas.ShowDialog();
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
