using Baser.DB.EntityFramework;
using Baser.DB.EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baser.GUI
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();

            // As fontes são dadas como essenciais
            // O programa não irá abrir caso elas não existam
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

            Activated += async (_, _) => await LoadAppAction();
        }

        private async Task LoadAppAction()
        {
            using(EntityContext context = new()) context.Database.EnsureCreated();

            if (string.IsNullOrEmpty(ConfigurationManager.AppSettings["user"]))
            {
                LoginApp();
                return;
            }

            List<Task> toLoad = new();
            toLoad.Add(Task.Delay(2000));
            toLoad.Add(Task.Run(() => lblStatusCarregamento.Invoke((MethodInvoker) delegate { lblStatusCarregamento.Text = "Carregando..."; })));
            await Task.WhenAll(toLoad);

            Close();
        }

        private void LoginApp()
        {
            Login login = new();
            login.Show();
            login.BringToFront();
        }
    }
}
