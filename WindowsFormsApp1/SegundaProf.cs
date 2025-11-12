using ProjetoProg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            timerVerificarAulas.Tick += timerVerificarAulas_Tick;
            timerVerificarAulas.Start(); // já começa ativo
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

        private void Lblteacher_Click(object sender, EventArgs e)
        {

        }

        private void LblArrow3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LblAlunos_Click(object sender, EventArgs e)
        {
            TodosOsAlunosUserControl alunosControl = new TodosOsAlunosUserControl();

            // 2. Assumindo que 'PainelPrincipal' é o Panel que hospeda os UserControls
            Panel4.Controls.Clear();
            Panel4.Controls.Add(alunosControl);
            alunosControl.Dock = DockStyle.Fill;
        }

        private void AgendarAulas_Click(object sender, EventArgs e)
        {
            AdicionarAulasUserControl alunosControl = new AdicionarAulasUserControl();
            Panel4.Controls.Clear();
            Panel4.Controls.Add(alunosControl);
            alunosControl.Dock = DockStyle.Fill;
        }

        private void LblVerAulas_Click(object sender, EventArgs e)
        {
            VisualizarAgendaUserControl alunosControl = new VisualizarAgendaUserControl();
            Panel4.Controls.Clear();
            Panel4.Controls.Add(alunosControl);
            alunosControl.Dock = DockStyle.Fill;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ExcluirContaProfessorUserControl alunosControl = new ExcluirContaProfessorUserControl();
            Panel4.Controls.Clear();
            Panel4.Controls.Add(alunosControl);
            alunosControl.Dock = DockStyle.Fill;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timerVerificarAulas_Tick(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=SQLEXPRESS;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    a.ID_AULA, 
                    a.LINK_MEET, 
                    c.NOME_CURSO, 
                    p.EMAIL_PROFESSOR, 
                    al.EMAIL_ALUNO
                FROM AULAS_AGENDADAS a
                INNER JOIN CURSOS c ON a.ID_CURSO = c.ID_CURSO
                INNER JOIN PROFESSORES p ON a.ID_PROFESSOR = p.ID_PROFESSOR
                INNER JOIN ALUNOS al ON a.ID_ALUNO = al.ID_ALUNO
                WHERE DATEDIFF(MINUTE, GETDATE(), a.DATA_HORA) = 5
            ";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string nomeCurso = reader["NOME_CURSO"].ToString();
                        string emailProf = reader["EMAIL_PROFESSOR"].ToString();
                        string emailAluno = reader["EMAIL_ALUNO"].ToString();
                        string linkMeet = reader["LINK_MEET"].ToString();

                        // Enviar emails
                        EnviarEmail(emailProf, nomeCurso, linkMeet, "professor");
                        EnviarEmail(emailAluno, nomeCurso, linkMeet, "aluno");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro no timer: {ex.Message}");
            }
        }

        private void EnviarEmail(string destino, string curso, string link, string tipo)
        {
            try
            {
                string remetente = "clarafzserejo@gmail.com";
                string senhaApp = "bwyz ldvp bvpt gqyg";

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(remetente);
                mail.To.Add(destino);
                mail.Subject = $"Aviso de Aula - {curso}";

                mail.Body = $@"
            <html>
            <body style='font-family: Arial, sans-serif; color: #333;'>
                <h2 style='color: #386a8b;'>Redefinição de senha</h2>
                <p>Olá 👋,</p>
                <p>Sua aula de {curso} começará em 5 minutos!</p>
                <p>Link do Meet: {link}</p>

          
                <p>Equipe Lumen Academy 🤓! </p>

                <p style='margin-top: 30px; font-size: 12px; color: #888;'>Este é um e-mail automático. Por favor, não responda.</p>
            </body>
            </html>";

                mail.IsBodyHtml = true;


                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(remetente, senhaApp);
                smtp.EnableSsl = true;
                smtp.Send(mail);

                Console.WriteLine($"Email enviado para {tipo}: {destino}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao enviar e-mail para {destino}: {ex.Message}");
            }
        }


    }
}
