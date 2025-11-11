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
            // 1. Obtém o ID do professor logado (VARCHAR/String)
            string idAlunoStr = SessaoUsuario.IdUsuario;

            if (string.IsNullOrEmpty(idAlunoStr))
            {
                MessageBox.Show("Erro de sessão: ID do aluno não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Confirmação
            DialogResult confirmacao = MessageBox.Show(
                "Tem certeza que deseja EXCLUIR PERMANENTEMENTE sua conta de professor? Todos os seus dados (aulas, cursos vinculados) serão APAGADOS.",
                "Confirmação de Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacao == DialogResult.No) return;

            string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    // =========================================================================
                    // ETAPA 1: EXCLUIR DADOS FILHOS (Em ordem inversa de dependência)
                    // =========================================================================

                    // 1.a) NOVO PASSO: Excluir registros na tabela RESETSENHAALUNOS
                    SqlCommand cmdReset = new SqlCommand(
                        "DELETE FROM RESETSENHAALUNOS WHERE ID_ALUNO_RESET = @idAluno", con, transaction);
                    cmdReset.Parameters.AddWithValue("@idAluno", idAlunoStr);
                    cmdReset.ExecuteNonQuery();

                    // 1.b) Excluir aulas agendadas
                    SqlCommand cmdAulas = new SqlCommand(
                        "DELETE FROM AULAS_AGENDADAS WHERE ID_ALUNO = @idAluno", con, transaction);
                    cmdAulas.Parameters.AddWithValue("@idAluno", idAlunoStr);
                    cmdAulas.ExecuteNonQuery();

                    

                    // =========================================================================
                    // ETAPA 2: EXCLUIR O REGISTRO PRINCIPAL (ALUNOS)
                    // =========================================================================

                    SqlCommand cmdProfessor = new SqlCommand(
                        "DELETE FROM ALUNOS WHERE ID_ALUNO = @idAluno", con, transaction);
                    cmdProfessor.Parameters.AddWithValue("@idAluno", idAlunoStr);

                    int rowsAffected = cmdProfessor.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        // Se não excluiu o registro principal, algo está errado
                        throw new Exception("O professor não pôde ser excluído ou não existe.");
                    }

                    // Confirma todas as exclusões
                    transaction.Commit();

                    // ... (Restante do código: MessageBox e SairESairDoSistema) ...
                    MessageBox.Show("Sua conta foi excluída com sucesso.", "Exclusão Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SairDoSistema();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Erro ao excluir conta: " + ex.Message, "Erro Crítico de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
