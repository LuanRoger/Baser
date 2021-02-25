using System;
using System.Configuration;
using System.Drawing;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baser.GUI
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();

            #region MenuClick
            mnuPrincipal.Click += (sender, e) => throw new NotImplementedException();
            mnuConfiguracoes.Click += (sender, e) =>
            {
                Configuracoes configuracoes = new();
                configuracoes.Show();
            };
            mnuSobre.Click += (sender, e) =>
            {
                MessageBox.Show($"Baser v{Assembly.GetExecutingAssembly().GetName().Version}" +
                                "\n" + "Luan Roger© 2021" +
                                "\n" + "Icone do programa: Benno Meyer", "Sobre",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            #endregion
        }

        private void tmrInicio_Tick(object sender, EventArgs e) => lblTempo.Text = DateTime.Now.ToString();

        private async void Inicio_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            this.Opacity = 0;

            SplashScreen splashScreen = new();
            splashScreen.Show();
            await Task.Delay(3000);

            if (String.IsNullOrEmpty(ConfigurationManager.AppSettings["user"])) return;
            splashScreen.Close();
            this.ShowInTaskbar = true;
            this.Opacity = 100;
            this.BringToFront();

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
                    this.Close();
                    break;
                case Keys.F7:
                    btnSairConta.PerformClick();
                    break;
            }
        }
    }
}
