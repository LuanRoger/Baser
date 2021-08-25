using System;
using System.Windows.Forms;
using Baser.Strings;
using Baser.DB.EntityFramework.Models;
using Baser.Enum;

namespace Baser.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            LanguagesResouces.GetGlobalizationInstance().LangTextObserver += Login_LangTextObserver;
            LanguagesResouces.GetGlobalizationInstance().StartGlobalization();
        }

        private void Login_LangTextObserver(object sender, GlobalStrings.UpdateModeEventArgs updateModeEventArgs)
        {
            label1.Text = LanguagesResouces.GetGlobalizationInstance().SetText(0, 11);
            label2.Text = LanguagesResouces.GetGlobalizationInstance().SetText(0, 12);
            btnEntrarLogin.Text = LanguagesResouces.GetGlobalizationInstance().SetText(0, 14);
            btnFecharLogin.Text = LanguagesResouces.GetGlobalizationInstance().SetText(0, 15);
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