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

            // 3. Define data de expiração (por exemplo, 15 minutos a partir de agora)
            DateTime dataExpiracao = DateTime.Now.AddMinutes(15);

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno"))
                {
                    con.Open();

                    // Verifica se o e-mail pertence a um aluno
                    string verificaAluno = @"
                        SELECT COUNT(*) FROM ALUNOS WHERE EMAIL_ALUNO = @EMAIL";
                    SqlCommand cmdVerificaAluno = new SqlCommand(verificaAluno, con);
                    cmdVerificaAluno.Parameters.AddWithValue("@EMAIL", emailDestino);
                    int existeAluno = Convert.ToInt32(cmdVerificaAluno.ExecuteScalar());

                    // Se for aluno
                    if (existeAluno > 0)
                    {
                        // **CORREÇÃO**: Verifica se já existe QUALQUER registro para este aluno
                        string verificaRegistroAluno = @"
                            SELECT COUNT(*) 
                            FROM RESETSENHAALUNOS 
                            WHERE ID_ALUNO_RESET = (SELECT ID_ALUNO FROM ALUNOS WHERE EMAIL_ALUNO = @EMAIL)";
                        SqlCommand cmdVerificaRegistroAluno = new SqlCommand(verificaRegistroAluno, con);
                        cmdVerificaRegistroAluno.Parameters.AddWithValue("@EMAIL", emailDestino);
                        int existeRegistroAluno = Convert.ToInt32(cmdVerificaRegistroAluno.ExecuteScalar());

                        if (existeRegistroAluno > 0)
                        {
                            // Se já existe, apenas atualiza código, data de expiração e zera o USADO
                            string updateCodigo = @"
                                UPDATE RESETSENHAALUNOS 
                                SET CODIGO = @CODIGO, EXPIRAEM = @EXPIRAEM, USADO = 0
                                WHERE ID_ALUNO_RESET = (SELECT ID_ALUNO FROM ALUNOS WHERE EMAIL_ALUNO = @EMAIL)";
                            SqlCommand cmdUpdateCodigo = new SqlCommand(updateCodigo, con);
                            cmdUpdateCodigo.Parameters.AddWithValue("@CODIGO", codigo);
                            cmdUpdateCodigo.Parameters.AddWithValue("@EXPIRAEM", dataExpiracao);
                            cmdUpdateCodigo.Parameters.AddWithValue("@EMAIL", emailDestino);
                            cmdUpdateCodigo.ExecuteNonQuery();
                        }
                        else
                        {
                            // Se não existe, insere um novo código de reset para o aluno
                            string insertAluno = @"
                                INSERT INTO RESETSENHAALUNOS (ID_ALUNO_RESET, CODIGO, EXPIRAEM, USADO)
                                SELECT ID_ALUNO, @CODIGO, @EXPIRAEM, 0 FROM ALUNOS WHERE EMAIL_ALUNO = @EMAIL";
                            SqlCommand cmdInsertAluno = new SqlCommand(insertAluno, con);
                            cmdInsertAluno.Parameters.AddWithValue("@CODIGO", codigo);
                            cmdInsertAluno.Parameters.AddWithValue("@EXPIRAEM", dataExpiracao);
                            cmdInsertAluno.Parameters.AddWithValue("@EMAIL", emailDestino);
                            cmdInsertAluno.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // Se não for aluno, verifica se é professor
                        string verificaProfessor = @"
                            SELECT COUNT(*) FROM PROFESSORES WHERE EMAIL_PROFESSOR = @EMAIL";
                        SqlCommand cmdVerificaProfessor = new SqlCommand(verificaProfessor, con);
                        cmdVerificaProfessor.Parameters.AddWithValue("@EMAIL", emailDestino);
                        int existeProfessor = Convert.ToInt32(cmdVerificaProfessor.ExecuteScalar());

                        // Se for professor
                        if (existeProfessor > 0)
                        {
                            // Verifica se já existe um código não usado para este professor
                            string verificaCodigoExistenteProf = @"
                                SELECT COUNT(*) FROM RESETSENHAPROFESSORES 
                                WHERE ID_PROFESSOR_RESET = (SELECT ID_PROFESSOR FROM PROFESSORES WHERE EMAIL_PROFESSOR = @EMAIL) 
                                AND USADO = 0";
                            SqlCommand cmdVerificaCodigoProf = new SqlCommand(verificaCodigoExistenteProf, con);
                            cmdVerificaCodigoProf.Parameters.AddWithValue("@EMAIL", emailDestino);
                            int codigoExistenteProf = Convert.ToInt32(cmdVerificaCodigoProf.ExecuteScalar());

                            if (codigoExistenteProf > 0)
                            {
                                // Se já existe um código não usado, atualiza o código e a data de expiração
                                string updateCodigoProf = @"
                                    UPDATE RESETSENHAPROFESSORES 
                                    SET CODIGO = @CODIGO, EXPIRAEM = @EXPIRAEM 
                                    WHERE ID_PROFESSOR_RESET = (SELECT ID_PROFESSOR FROM PROFESSORES WHERE EMAIL_PROFESSOR = @EMAIL) 
                                    AND USADO = 0";
                                SqlCommand cmdUpdateCodigoProf = new SqlCommand(updateCodigoProf, con);
                                cmdUpdateCodigoProf.Parameters.AddWithValue("@CODIGO", codigo);
                                cmdUpdateCodigoProf.Parameters.AddWithValue("@EXPIRAEM", dataExpiracao);
                                cmdUpdateCodigoProf.Parameters.AddWithValue("@EMAIL", emailDestino);
                                cmdUpdateCodigoProf.ExecuteNonQuery();
                            }
                            else
                            {
                                // Se não existe código, insere um novo código de reset para o professor
                                string insertProfessor = @"
                                    INSERT INTO RESETSENHAPROFESSORES (ID_PROFESSOR_RESET, CODIGO, EXPIRAEM, USADO)
                                    SELECT ID_PROFESSOR, @CODIGO, @EXPIRAEM, 0 FROM PROFESSORES WHERE EMAIL_PROFESSOR = @EMAIL";
                                SqlCommand cmdInsertProfessor = new SqlCommand(insertProfessor, con);
                                cmdInsertProfessor.Parameters.AddWithValue("@CODIGO", codigo);
                                cmdInsertProfessor.Parameters.AddWithValue("@EXPIRAEM", dataExpiracao);
                                cmdInsertProfessor.Parameters.AddWithValue("@EMAIL", emailDestino);
                                cmdInsertProfessor.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            MessageBox.Show("E-mail não encontrado.");
                            return;
                        }
                    }
                }

                // 4. Envia o código de verificação para o e-mail do usuário
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
                        SELECT EMAIL_PROFESSOR FROM PROFESSORES WHERE EMAIL_PROFESSOR = @EMAIL
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
                    INNER JOIN ALUNOS a ON rsa.ID_ALUNO_RESET = a.ID_ALUNO
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
                    string updateAluno = "UPDATE RESETSENHAALUNOS SET USADO = 1 WHERE ID_ALUNO_RESET = @ID_ALUNO AND CODIGO = @CODIGO";
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
                        INNER JOIN PROFESSORES p ON rsp.ID_PROFESSOR_RESET = p.ID_PROFESSOR
                        WHERE p.EMAIL_PROFESSOR = @EMAIL
                        AND rsp.CODIGO = @CODIGO
                        AND rsp.USADO = 0
                        AND rsp.EXPIRAEM > GETDATE()";

                    SqlCommand cmdProf = new SqlCommand(sqlProf, con);
                    cmdProf.Parameters.AddWithValue("@EMAIL", email);
                    cmdProf.Parameters.AddWithValue("@CODIGO", codigo);

                    object resultadoProf = cmdProf.ExecuteScalar();

                    if (resultadoProf != null)
                    {
                        string updateProf = "UPDATE RESETSENHAPROFESSORES SET USADO = 1 WHERE ID_PROFESSOR_RESET = @ID_PROFESSOR AND CODIGO = @CODIGO";
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
                this.Visible = false;
              
                formAtualizarSenha.ShowDialog();

            }
            else
            {
                MessageBox.Show("Código inválido ou expirado.");
            }
        }
    }
}

