using System;
using System.Windows.Forms;
using Baser.Enum;
using Baser.Managers;
using Baser.Managers.Configuration;
using GlobalStrings.EventArguments;

namespace Baser.GUI
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void GlobalizationOnLangTextObserver(object sender, UpdateModeEventArgs updatemodeeventargs)
        {
            btnSairConta.Size = updatemodeeventargs.lang switch
            {
                LanguageCode.PT_BR => new(100, 23),
                LanguageCode.EN_US => new(70, 23)
            };
            
            mnuPrincipal.Text = LanguageManager.ReturnGlobalizationText("Home", "MenuHome");
            mnuMostrarLista.Text = LanguageManager.ReturnGlobalizationText("Home", "SmenuShowList");
            mnuConfiguracoes.Text = LanguageManager.ReturnGlobalizationText("Home", "MenuConfiguration");
            mnuSobre.Text = LanguageManager.ReturnGlobalizationText("Home", "MenuAbout");
            btnSairConta.Text = LanguageManager.ReturnGlobalizationText("Home", "ButtonLogout");
            toolStripStatusLabel1.Text = LanguageManager.ReturnGlobalizationText("Home", "ShortcutLogout");
            toolStripStatusLabel2.Text = LanguageManager.ReturnGlobalizationText("Home", "ShortcutExit");
        }

        private void tmrInicio_Tick(object sender, EventArgs e) => lblTempo.Text = DateTime.Now.ToString();

        private void Inicio_Load(object sender, EventArgs e)
        {
            ShowInTaskbar = false;
            Opacity = 0;

            SplashScreen splashScreen = new();
            splashScreen.Show();
            splashScreen.FormClosed += (_, _) => {
                ShowInTaskbar = true;
                Opacity = 1;
                BringToFront();
            };
            
            #region MenuClick
            mnuMostrarLista.Click += (_, _) =>
            {
                Lista lista = new(null);
                lista.Show();
            };
            mnuConfiguracoes.Click += (_, _) =>
            {
                Configuracoes configuracoes = new();
                configuracoes.Show();
            };
            mnuSobre.Click += (_, _) =>
            {
                Sobre sobre = new();
                sobre.Show();
            };
            #endregion

            lblUsuario.Text = AppConfigurationManger.configManager.userSection.userName;

            LanguageManager.SetGlobalizationObserver(GlobalizationOnLangTextObserver);
        }

        private void btnSairConta_Click(object sender, EventArgs e)
        {
            AppConfigurationManger.configManager.userSection = AppConfigurationManger.configManager.userSection with
            {
                  userName = ""
            };
            AppConfigurationManger.SaveConfig();

            AppManager.ReiniciarPrograma();
        }

        private void Inicio_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F6:
                    Close();
                    break;
                case Keys.F7:
                    btnSairConta.PerformClick();
                    break;
            }
        }
    }
}
