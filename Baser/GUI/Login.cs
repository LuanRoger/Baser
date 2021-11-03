using System;
using System.Windows.Forms;
using Baser.Enum;
using Baser.Managers;
using Baser.Managers.Configuration;
using GlobalStrings.EventArguments;

namespace Baser.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            LanguageManager.SetGlobalizationObserver(GlobalizationOnLangTextObserver);
        }

        private void GlobalizationOnLangTextObserver(object sender, UpdateModeEventArgs updatemodeeventargs)
        {
            Text = LanguageManager.ReturnGlobalizationText("Login", "WindowTitle");
            label1.Text = LanguageManager.ReturnGlobalizationText("Login", "LabelUsername");
            label2.Text = LanguageManager.ReturnGlobalizationText("Login", "LabelPassword");
            btnEntrarLogin.Text = LanguageManager.ReturnGlobalizationText("Login", "ButtonEnter");
            btnFecharLogin.Text = LanguageManager.ReturnGlobalizationText("Login", "ButtonClose");
        }

        private void btnFecharLogin_Click(object sender, EventArgs e) => Application.Exit();
        
        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtLoginUsuario.Text.Trim();
            string senha = txtLoginSenha.Text.Trim();

            //THE PASSWORD IS NOT VERIFIED
            if (Verificadores.VerificarStrings(usuario, senha))
            {
                MessageBox.Show("Preencha os campos para continuar", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AppConfigurationManger.configManager.userSection = AppConfigurationManger.configManager.userSection with
            {
                  userName = usuario,
                  userType = UserType.USU
            };
            AppConfigurationManger.SaveConfig();

            AppManager.ReiniciarPrograma();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e) => Environment.Exit(0);

        private void txtLoginSenha_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Enter:
                    btnEntrarLogin.PerformClick();
                    break;
            }
        }
    }
}