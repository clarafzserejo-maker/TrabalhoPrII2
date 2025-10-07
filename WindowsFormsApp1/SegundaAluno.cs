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
using static ProjetoProg.Btn;

namespace WindowsFormsApp1
{
    public partial class SegundaAluno : Form
    {
        public SegundaAluno()
        {
            InitializeComponent();
            LblNameUser.Text = SessaoUsuario.Nome ?? "Usuário";
            LblEmailUser.Text = SessaoUsuario.Email ?? "email@exemplo.com";

            LblArrow.MouseEnter += (s, e) => LblArrow.ForeColor = Color.DimGray;
            LblArrow.MouseLeave += (s, e) => LblArrow.ForeColor = Color.Black;

            ContextMenuStrip menuPerfil = new ContextMenuStrip();
            menuPerfil.BackColor = Color.WhiteSmoke;
            menuPerfil.RenderMode = ToolStripRenderMode.System;
            menuPerfil.ShowImageMargin = false;
            menuPerfil.Items.Add("📤 Sair da conta", null, (s, e) =>
            {
                this.Hide();
                Btn telaLogin = new Btn();
                telaLogin.ShowDialog();
                this.Close();
            });

            // 🔹 Corrige a posição — abre logo abaixo da seta
            LblArrow.Click += (s, e) =>
            {
                // converte a posição da seta para coordenadas de tela
                var posicao = LblArrow.PointToScreen(new Point(0, LblArrow.Height));
                menuPerfil.Show(posicao); // abre exatamente abaixo da seta
            };
        }

        private void SegundaAluno_Load(object sender, EventArgs e)
        {

        }

        private void LblProfile_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void LblArrow_Click(object sender, EventArgs e)
        {
            
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
