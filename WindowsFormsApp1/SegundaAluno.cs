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
        private readonly Font FonteMenuPadrao = new Font("Microsoft Sans Serif", 15f, FontStyle.Regular);
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
            menuPerfil.Font = FonteMenuPadrao;
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


            ContextMenuStrip cursos = new ContextMenuStrip();
            cursos.BackColor = Color.WhiteSmoke;
            cursos.RenderMode = ToolStripRenderMode.System;
            cursos.ShowImageMargin = false;
            cursos.Font = FonteMenuPadrao;
            cursos.Items.Add("Meus cursos", null, (s, e) =>
            {
                CarregarTela(new VerCursosAlunoUserControl());
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
                CarregarTela(new AdicionarCursoAlunoUserControl());
            });

            // 🔹 Corrige a posição — abre logo abaixo da seta
            LblArrow3.Click += (s, e) =>
            {
                // converte a posição da seta para coordenadas de tela
                var posicao = LblArrow3.PointToScreen(new Point(0, LblArrow3.Height));
                cursos.Show(posicao); // abre exatamente abaixo da seta
            };

            ContextMenuStrip boletins = new ContextMenuStrip();
            boletins.BackColor = Color.WhiteSmoke;
            boletins.RenderMode = ToolStripRenderMode.System;
            boletins.ShowImageMargin = false;
            boletins.Font = FonteMenuPadrao;
            boletins.Items.Add("Visualizar boletins", null, (s, e) =>
            {
                CarregarTela(new VerBoletimAlunoUserControl());
            });

            // 🔹 Corrige a posição — abre logo abaixo da seta
            LblArrow7.Click += (s, e) =>
            {
                // converte a posição da seta para coordenadas de tela
                var posicao = LblArrow7.PointToScreen(new Point(0, LblArrow7.Height));
                boletins.Show(posicao); // abre exatamente abaixo da seta
            };

     



        }

        private void SegundaAluno_Load(object sender, EventArgs e)
        {
            PadraoControl telaInicial = new PadraoControl();
            telaInicial.Dock = DockStyle.Fill;

            // Adiciona ao painel principal
            Panel5.Controls.Clear();
            Panel5.Controls.Add(telaInicial);
        }

        private void CarregarTela(UserControl tela)
        {
            Panel5.Controls.Clear(); // limpa o painel
            tela.Dock = DockStyle.Fill;     // faz o controle preencher o painel
            Panel5.Controls.Add(tela);
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

        private void LblArrow3_Click(object sender, EventArgs e)
        {

        }

        private void LblAlunos_Click(object sender, EventArgs e)
        {
            VisualizarProfessorUserControl alunosControl = new VisualizarProfessorUserControl();

            // 2. Assumindo que 'PainelPrincipal' é o Panel que hospeda os UserControls
            Panel5.Controls.Clear();
            Panel5.Controls.Add(alunosControl);
            alunosControl.Dock = DockStyle.Fill;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ExcluirContaAlunoUserControl alunosControl = new ExcluirContaAlunoUserControl();
            Panel5.Controls.Clear();
            Panel5.Controls.Add(alunosControl);
            alunosControl.Dock = DockStyle.Fill;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LblVerAulas_Click(object sender, EventArgs e)
        {
            VisualizarAgendaUserControl alunosControl = new VisualizarAgendaUserControl();
            Panel5.Controls.Clear();
            Panel5.Controls.Add(alunosControl);
            alunosControl.Dock = DockStyle.Fill;
        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
