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
    public partial class SegundaProf : Form
    {

        public SegundaProf()
        {
            InitializeComponent();
            LblNameUser2.Text = SessaoUsuario.Nome ?? "Usuário";
            LblEmailUser2.Text = SessaoUsuario.Email ?? "email@exemplo.com";

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
            LblArrow2.Click += (s, e) =>
            {
                // converte a posição da seta para coordenadas de tela
                var posicao = LblArrow2.PointToScreen(new Point(0, LblArrow2.Height));
                menuPerfil.Show(posicao); // abre exatamente abaixo da seta
            };

            ContextMenuStrip cursos = new ContextMenuStrip();
            cursos.BackColor = Color.WhiteSmoke;
            cursos.RenderMode = ToolStripRenderMode.System;
            cursos.ShowImageMargin = false;
            cursos.Items.Add("Meus cursos", null, (s, e) =>
            {
                CarregarTela(new MeusCursosControl());
            });

            // 🔹 Corrige a posição — abre logo abaixo da seta
            LblArrow3.Click += (s, e) =>
            {
                // converte a posição da seta para coordenadas de tela
                var posicao = LblArrow3.PointToScreen(new Point(0, LblArrow3.Height));
                cursos.Show(posicao); // abre exatamente abaixo da seta
            };

            cursos.Items.Add("Adicionar curso", null, (s, e) =>
            {
                CarregarTela(new AdicionarCursoControl());
            });

            // 🔹 Corrige a posição — abre logo abaixo da seta
            LblArrow3.Click += (s, e) =>
            {
                // converte a posição da seta para coordenadas de tela
                var posicao = LblArrow3.PointToScreen(new Point(0, LblArrow3.Height));
                cursos.Show(posicao); // abre exatamente abaixo da seta
            };
        }
        

            private void CarregarTela(UserControl tela)
        {
            Panel4.Controls.Clear(); // limpa o painel
            tela.Dock = DockStyle.Fill;     // faz o controle preencher o painel
            Panel4.Controls.Add(tela);
        }

    

        private void Disciplinas_Load(object sender, EventArgs e)
        {
            PadraoControl telaInicial = new PadraoControl();
            telaInicial.Dock = DockStyle.Fill;

            // Adiciona ao painel principal
            Panel4.Controls.Clear();
            Panel4.Controls.Add(telaInicial);
        }

        private void LblNameUser_Click(object sender, EventArgs e)
        {

        }

        private void LblArrow2_Click(object sender, EventArgs e)
        {

        }
    }
}
