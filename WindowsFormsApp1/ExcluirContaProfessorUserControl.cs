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
    public partial class ExcluirContaProfessorUserControl : UserControl
    {
        public ExcluirContaProfessorUserControl()
        {
            InitializeComponent();
        }

        private void BtnAddCourse_Click(object sender, EventArgs e)
        {
            ExcluirContaProfessor();
        }

        private void ExcluirContaProfessor()
        {
            // 1. Obtém o ID do professor logado (VARCHAR/String)
            string idProfessorStr = SessaoUsuario.IdUsuario;

            if (string.IsNullOrEmpty(idProfessorStr))
            {
                MessageBox.Show("Erro de sessão: ID do professor não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    // 1.a) NOVO PASSO: Excluir registros na tabela RESETSENHAPROFESSORES
                    SqlCommand cmdReset = new SqlCommand(
                        "DELETE FROM RESETSENHAPROFESSORES WHERE ID_PROFESSOR_RESET = @idProfessor", con, transaction);
                    cmdReset.Parameters.AddWithValue("@idProfessor", idProfessorStr);
                    cmdReset.ExecuteNonQuery();

                    // 1.b) Excluir aulas agendadas
                    SqlCommand cmdAulas = new SqlCommand(
                        "DELETE FROM AULAS_AGENDADAS WHERE ID_PROFESSOR = @idProfessor", con, transaction);
                    cmdAulas.Parameters.AddWithValue("@idProfessor", idProfessorStr);
                    cmdAulas.ExecuteNonQuery();

                    // 1.c) Excluir vínculos CURSOS_PROFESSORES
                    SqlCommand cmdVinculos = new SqlCommand(
                        "DELETE FROM CURSOS_PROFESSORES WHERE ID_PROFESSOR = @idProfessor", con, transaction);
                    cmdVinculos.Parameters.AddWithValue("@idProfessor", idProfessorStr);
                    cmdVinculos.ExecuteNonQuery();

                    // =========================================================================
                    // ETAPA 2: EXCLUIR O REGISTRO PRINCIPAL (PROFESSORES)
                    // =========================================================================

                    SqlCommand cmdProfessor = new SqlCommand(
                        "DELETE FROM PROFESSORES WHERE ID_PROFESSOR = @idProfessor", con, transaction);
                    cmdProfessor.Parameters.AddWithValue("@idProfessor", idProfessorStr);

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SegundaProf login = new SegundaProf();
            this.Visible = false;
            login.ShowDialog();
            this.Visible = true;
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
    }
}
