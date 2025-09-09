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
                mail.From = new MailAddress("clarafserejo@gmail.com");
                mail.To.Add(emailDestino);
                mail.Subject = "Redefinição de Senha";
                mail.Body = $"Seu código para redefinir a senha é: {codigo}\n" +
                            "Esse código expira em 15 minutos.";

                // Servidor SMTP do Gmail
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("clarafzserejo@gmail.com", "abwb qfmf oyzj xnab");
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