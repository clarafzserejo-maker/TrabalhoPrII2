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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        private void BtnConfirmCode_Click(object sender, EventArgs e)
        {
            bool codigoValido = false;

            string email = TxbForgotEmail.Text.Trim();
            string codigo = TxbEnterCode.Text.Trim();

            using (SqlConnection con = new SqlConnection("Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno"))
            {
                con.Open();

                // Verifica se o e-mail existe em ALUNOS ou PROFESSORES
                string verificaEmail = @"
            SELECT COUNT(*) FROM (
                SELECT EMAIL_ALUNO AS EMAIL FROM ALUNOS WHERE EMAIL_ALUNO = @EMAIL
                UNION
                SELECT EMAIL FROM PROFESSORES WHERE EMAIL = @EMAIL
            ) AS EmailsEncontrados";

                SqlCommand cmdVerificaEmail = new SqlCommand(verificaEmail, con);
                cmdVerificaEmail.Parameters.AddWithValue("@EMAIL", email);

                int emailExiste = Convert.ToInt32(cmdVerificaEmail.ExecuteScalar());

                if (emailExiste == 0)
                {
                    MessageBox.Show("E-mail não encontrado.");
                    return;
                }

                // Verifica para aluno
                string sqlAluno = @"
            SELECT ID_ALUNO 
            FROM RESETSENHAALUNOS rsa
            INNER JOIN ALUNOS a ON rsa.ID_ALUNO = a.ID_ALUNO
            WHERE a.EMAIL_ALUNO = @EMAIL
              AND rsa.CODIGO = @CODIGO
              AND rsa.USADO = 0
              AND rsa.EXPIRAEM > GETDATE()";

                SqlCommand cmdAluno = new SqlCommand(sqlAluno, con);
                cmdAluno.Parameters.AddWithValue("@EMAIL", email);
                cmdAluno.Parameters.AddWithValue("@CODIGO", codigo);

                object resultadoAluno = cmdAluno.ExecuteScalar();

                if (resultadoAluno != null)
                {
                    string updateAluno = "UPDATE RESETSENHAALUNOS SET USADO = 1 WHERE ID_ALUNO = @ID_ALUNO AND CODIGO = @CODIGO";
                    SqlCommand cmdUpdateAluno = new SqlCommand(updateAluno, con);
                    cmdUpdateAluno.Parameters.AddWithValue("@ID_ALUNO", resultadoAluno.ToString());
                    cmdUpdateAluno.Parameters.AddWithValue("@CODIGO", codigo);
                    cmdUpdateAluno.ExecuteNonQuery();

                    codigoValido = true;
                }
                else
                {
                    // Se não achou aluno, verifica professor
                    string sqlProf = @"
                SELECT ID_PROFESSOR 
                FROM RESETSENHAPROFESSORES rsp
                INNER JOIN PROFESSORES p ON rsp.ID_PROFESSOR = p.ID_PROFESSOR
                WHERE p.EMAIL = @EMAIL
                  AND rsp.CODIGO = @CODIGO
                  AND rsp.USADO = 0
                  AND rsp.EXPIRAEM > GETDATE()";

                    SqlCommand cmdProf = new SqlCommand(sqlProf, con);
                    cmdProf.Parameters.AddWithValue("@EMAIL", email);
                    cmdProf.Parameters.AddWithValue("@CODIGO", codigo);

                    object resultadoProf = cmdProf.ExecuteScalar();

                    if (resultadoProf != null)
                    {
                        string updateProf = "UPDATE RESETSENHAPROFESSORES SET USADO = 1 WHERE ID_PROFESSOR = @ID_PROFESSOR AND CODIGO = @CODIGO";
                        SqlCommand cmdUpdateProf = new SqlCommand(updateProf, con);
                        cmdUpdateProf.Parameters.AddWithValue("@ID_PROFESSOR", resultadoProf.ToString());
                        cmdUpdateProf.Parameters.AddWithValue("@CODIGO", codigo);
                        cmdUpdateProf.ExecuteNonQuery();

                        codigoValido = true;
                    }
                }
            }

            if (codigoValido)
            {
                MessageBox.Show("Código válido! Agora você pode atualizar sua senha.");

                // Abre a tela de atualização de senha
                Form4 formAtualizarSenha = new Form4(email);
                formAtualizarSenha.Show();

                this.Hide(); // Fecha ou esconde a tela atual
            }
            else
            {
                MessageBox.Show("Código inválido ou expirado.");
            }
        }
    }

}