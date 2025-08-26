namespace ProjetoProg
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxbUser;
        private System.Windows.Forms.TextBox TxbPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LblCreateAccount;
        private System.Windows.Forms.LinkLabel LinkLblCreateAccount;
        private System.Windows.Forms.LinkLabel LinkLblForgotAccount;
    }
}