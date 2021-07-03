using System;
using System.Configuration;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Baser.Strings;

namespace Baser.GUI
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            LanguagesResouces.GetGlobalizationInstance().LangTextObserver += Globalization_LangTextObserver;
            LanguagesResouces.GetGlobalizationInstance().StartGlobalization();

            #region MenuClick
            mnuMostrarLista.Click += (sender, e) =>
            {
                Lista lista = new Lista(null);
                lista.Show();
            };
            mnuConfiguracoes.Click += (sender, e) =>
            {
                Configuracoes configuracoes = new();
                configuracoes.Show();
            };
            mnuSobre.Click += (sender, e) =>
            {
                Sobre sobre = new();
                sobre.Show();
            };
            #endregion
        }

        private void Globalization_LangTextObserver(object sender, GlobalStrings.UpdateModeEventArgs updateModeEventArgs)
        {
            btnSairConta.Size = updateModeEventArgs.lang switch
            {
                0 => new Size(100, 23),
                1 => new Size(70, 23)
            };
            Text = LanguagesResouces.GetGlobalizationInstance().SetText(3);
            mnuPrincipal.Text = LanguagesResouces.GetGlobalizationInstance().SetText(4);
            mnuMostrarLista.Text = LanguagesResouces.GetGlobalizationInstance().SetText(5);
            mnuConfiguracoes.Text = LanguagesResouces.GetGlobalizationInstance().SetText(6);
            mnuSobre.Text = LanguagesResouces.GetGlobalizationInstance().SetText(7);
            btnSairConta.Text = LanguagesResouces.GetGlobalizationInstance().SetText(8);
            toolStripStatusLabel1.Text = LanguagesResouces.GetGlobalizationInstance().SetText(9);
            toolStripStatusLabel2.Text = LanguagesResouces.GetGlobalizationInstance().SetText(10);
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
                Opacity = 100;
                BringToFront();
            };

            lblUsuario.Text = ConfigurationManager.AppSettings["user"];
            lblUsuario.BackColor = Color.Transparent;
        }

        private void btnSairConta_Click(object sender, EventArgs e)
        {
            Configuracoes.config.AppSettings.Settings["user"].Value = "";
            Configuracoes.config.Save();

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
