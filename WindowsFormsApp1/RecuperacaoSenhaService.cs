using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class RecuperacaoSenhaService
    {

        public static void EnviarEmailRedefinicao(string emailDestino, string codigo)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("clarafzserejo@gmail.com");
                mail.To.Add(emailDestino);
                mail.Subject = "Redefinição de Senha";

                mail.Body = $@"
            <html>
            <body style='font-family: Arial, sans-serif; color: #333;'>
                <h2 style='color: #386a8b;'>Redefinição de senha</h2>
                <p>Olá 👋,</p>
                <p>Você solicitou a redefinição de sua senha.</p>
                <p>Use o código abaixo para continuar:</p>

               <div style='
    background-color: #8dbcc7; 
    color: #386a8b;
    padding: 10px 20px; 
    display: inline-block;
    font-size: 24px; 
    font-weight: bold; 
    border-radius: 5px; 
    border: 1px solid #8dbcc7; 
    margin: 20px 0;
'>
    {codigo}
</div>

                <p>Esse código expira em <strong>15 minutos</strong>.</p>
                <p>Se você não solicitou isso, pode ignorar este e-mail.</p>
                <p>Equipe IQverse 🤓! </p>

                <p style='margin-top: 30px; font-size: 12px; color: #888;'>Este é um e-mail automático. Por favor, não responda.</p>
            </body>
            </html>";

                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("clarafzserejo@gmail.com", "bwyz ldvp bvpt gqyg");
                smtp.EnableSsl = true;

                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao enviar e-mail: " + ex.Message);
            }
        }



        private void SalvarCodigoNoBanco(string usuario, string email, string codigo)
        {
            string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno";

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                conexao.Open();

                // Atualiza o código na tabela ALUNOS
                string updateAluno = "UPDATE ALUNOS SET CODREC = @codigo WHERE ID_ALUNO = @usuario AND EMAIL_ALUNO = @email";
                using (SqlCommand cmdAluno = new SqlCommand(updateAluno, conexao))
                {
                    cmdAluno.Parameters.AddWithValue("@codigo", codigo);
                    cmdAluno.Parameters.AddWithValue("@usuario", usuario);
                    cmdAluno.Parameters.AddWithValue("@email", email);

                    int linhasAfetadasAluno = cmdAluno.ExecuteNonQuery();

                    if (linhasAfetadasAluno > 0)
                    {
                        return; // Código salvo em ALUNOS
                    }
                }

                // Se não atualizou em ALUNOS, tenta PROFESSORES
                string updateProfessor = "UPDATE PROFESSORES SET CODREC = @codigo WHERE ID_PROFESSOR = @usuario AND EMAIL_PROFESSOR = @email";
                using (SqlCommand cmdProfessor = new SqlCommand(updateProfessor, conexao))
                {
                    cmdProfessor.Parameters.AddWithValue("@codigo", codigo);
                    cmdProfessor.Parameters.AddWithValue("@usuario", usuario);
                    cmdProfessor.Parameters.AddWithValue("@email", email);

                    int linhasAfetadasProfessor = cmdProfessor.ExecuteNonQuery();

                    if (linhasAfetadasProfessor > 0)
                    {
                        return; // Código salvo em PROFESSORES
                    }
                }

                throw new Exception("Usuário ou email não encontrados para salvar o código.");
            }
        }



    }
}