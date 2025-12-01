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
using static ProjetoProg.Btn;

namespace WindowsFormsApp1
{
    public partial class ExcluirContaAlunoUserControl : UserControl
    {
        public ExcluirContaAlunoUserControl()
        {
            InitializeComponent();
        }

        private void ExcluirContaAlunoUserControl_Load(object sender, EventArgs e)
        {

        }

        private void ExcluirContaAluno()
        {
            string idAlunoStr = SessaoUsuario.IdUsuario;

            if (string.IsNullOrEmpty(idAlunoStr))
            {
                MessageBox.Show("Erro de sessão: ID do aluno não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirmacao = MessageBox.Show(
                "Tem certeza que deseja EXCLUIR PERMANENTEMENTE sua conta de aluno? Todos os seus dados serão APAGADOS.",
                "Confirmação de Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacao == DialogResult.No) return;

            string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();

                    try
                    {
                        // 1. Exclui dependências

                        SqlCommand cmd1 = new SqlCommand(
                            "DELETE FROM BOLETINS WHERE ID_ALUNO = @idAluno",
                            con, transaction);
                        cmd1.Parameters.Add("@idAluno", SqlDbType.NVarChar, 50).Value = idAlunoStr;
                        cmd1.ExecuteNonQuery();

                        SqlCommand cmd2 = new SqlCommand(
                            "DELETE FROM ALUNOS_CURSOS WHERE ID_ALUNO = @idAluno",
                            con, transaction);
                        cmd2.Parameters.Add("@idAluno", SqlDbType.NVarChar, 50).Value = idAlunoStr;
                        cmd2.ExecuteNonQuery();

                        SqlCommand cmd3 = new SqlCommand(
                            "DELETE FROM RESETSENHAALUNOS WHERE ID_ALUNO_RESET = @idAluno",
                            con, transaction);
                        cmd3.Parameters.Add("@idAluno", SqlDbType.NVarChar, 50).Value = idAlunoStr;
                        cmd3.ExecuteNonQuery();

                        // 2. Exclui aluno
                        SqlCommand cmdFinal = new SqlCommand(
                            "DELETE FROM ALUNOS WHERE ID_ALUNO = @idAluno",
                            con, transaction);
                        cmdFinal.Parameters.Add("@idAluno", SqlDbType.NVarChar, 50).Value = idAlunoStr;
                        cmdFinal.ExecuteNonQuery();

                        // CONFIRMA TUDO
                        transaction.Commit();
                        MessageBox.Show("Conta excluída com sucesso.", "Sucesso");
                        SairDoSistema();
                    }
                    catch (Exception exTransacao)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Falha na exclusão da conta. Erro: " + exTransacao.Message, "Erro de Banco de Dados");
                    }
                }
                catch (Exception exConexao)
                {
                    MessageBox.Show("Erro de conexão ao excluir conta: " + exConexao.Message, "Erro Crítico");
                }
            }
        }


        private void SairDoSistema()
        {
            // 1. Limpa a Sessão
            // É uma boa prática limpar todas as variáveis de sessão para garantir que ninguém 
            // fique logado se o aplicativo for reaberto.
            SessaoUsuario.IdUsuario = null;
            SessaoUsuario.Email = null;
            // Se você tiver outras propriedades na SessaoUsuario, limpe-as também (ex: TipoUsuario = null)

            // 2. Abre a Tela de Login
            // Assumindo que sua tela de login se chama FormLogin
            Btn loginForm = new Btn();
            loginForm.Show();

            // 3. Fecha o Formulário Principal Atual
            // O 'this.FindForm()' retorna o Form principal que contém este UserControl.
            this.FindForm().Close();
        }
        private void BtnExcluirConta_Click(object sender, EventArgs e)
        {
            ExcluirContaAluno();
        }
    }
}
