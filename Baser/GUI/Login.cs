using System;
using System.Windows.Forms;

namespace Baser.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnFecharLogin_Click(object sender, EventArgs e) => Application.Exit();
        
        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtLoginUsuario.Text.Trim();
            string senha = txtLoginSenha.Text;

            if (Verificadores.VerificarStrings(txtLoginUsuario.Text /*Senha não verificada (Padrão)*/))
            {
                MessageBox.Show("Preencha os campos para continuar", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Salvar usuário
            Configuracoes.config.AppSettings.Settings["user"].Value = usuario;
            Configuracoes.config.Save();

            AppManager.ReiniciarPrograma();
        }
    }
}