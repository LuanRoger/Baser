using System;
using System.Drawing;
using System.Windows.Forms;
using Baser.Strings;

namespace Baser.GUI
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Globalization_LangTextObserver(object sender, GlobalStrings.UpdateModeEventArgs updateModeEventArgs)
        {
            btnSairConta.Size = updateModeEventArgs.lang switch
            {
                0 => new(100, 23),
                1 => new(70, 23)
            };
            Text = LanguagesResouces.GetGlobalizationInstance().SetText(0, 3);
            mnuPrincipal.Text = LanguagesResouces.GetGlobalizationInstance().SetText(0, 4);
            mnuMostrarLista.Text = LanguagesResouces.GetGlobalizationInstance().SetText(0, 5);
            mnuConfiguracoes.Text = LanguagesResouces.GetGlobalizationInstance().SetText(0, 6);
            mnuSobre.Text = LanguagesResouces.GetGlobalizationInstance().SetText(0, 7);
            btnSairConta.Text = LanguagesResouces.GetGlobalizationInstance().SetText(0, 8);
            toolStripStatusLabel1.Text = LanguagesResouces.GetGlobalizationInstance().SetText(0, 9);
            toolStripStatusLabel2.Text = LanguagesResouces.GetGlobalizationInstance().SetText(0, 10);
        }

        private void tmrInicio_Tick(object sender, EventArgs e) => lblTempo.Text = DateTime.Now.ToString();
        
        private void Inicio_Activated(object sender, EventArgs e)
        {
            if(Verificadores.IsVisible(this))
            {
                LanguagesResouces.GetGlobalizationInstance()
                    .UpdateLang(AppConfigurationManger.configManager.LanguageSection.langCode);
            }
        }
        
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

            LanguagesResouces.GetGlobalizationInstance().LangTextObserver += Globalization_LangTextObserver;
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
