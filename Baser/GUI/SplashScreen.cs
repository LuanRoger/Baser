using System;
using System.Configuration;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Baser.GUI
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();

            try
            {
                PrivateFontCollection privateFont = new PrivateFontCollection();
                privateFont.AddFontFile(Application.StartupPath + @"font\\Montserrat-ExtraBold.ttf");
                privateFont.AddFontFile(Application.StartupPath + @"font\\Montserrat-ExtraLight.ttf");
                label1.Font = new Font(privateFont.Families[0], 20, FontStyle.Bold);
                label2.Font = new Font(privateFont.Families[1], 7, FontStyle.Regular);
            }
            catch
            {
                MessageBox.Show("Está faltando arquivos essenciais para inicialização do programa, tente reinstalá-lo novamente.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            //Carregar
            lblStatusCarregamento.Text = "Fazendo login...";
            LoginApp();

            lblStatusCarregamento.Text = "Carregando..."; // Todo
        }

        private void LoginApp()
        {
            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["user"])) return;

            Login login = new();
            login.Show();
            login.BringToFront();
        }
    }
}
