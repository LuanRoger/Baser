using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baser.Strings;

namespace Baser.GUI
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            
            AppManager.CreateAppDirectory();
            
            if (File.Exists(Consts.CONFIG_FILE_PATH)) AppConfigurationManger.LoadConfig();
            else AppConfigurationManger.SaveConfig();
            
            try
            {
                PrivateFontCollection privateFont = new();
                privateFont.AddFontFile(Consts.FONT_MONTSERRAT_EXTRABOLD);
                privateFont.AddFontFile(Consts.FONT_MONTSERRAT_EXTRALIGHT);
                label1.Font = new(privateFont.Families[0], 20, FontStyle.Bold);
                label2.Font = new(privateFont.Families[1], 7, FontStyle.Regular);
            }
            catch
            {
                MessageBox.Show("Está faltando arquivos essenciais para inicialização do programa, tente reinstalá-lo novamente.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            Load += async (_, _) => await LoadAppAction();
        }

        private async Task LoadAppAction()
        {
            if (string.IsNullOrEmpty(AppConfigurationManger.configManager.userSection.userName))
            {
                LoginApp();
                return;
            }
            
            LanguagesResouces.GetGlobalizationInstance().StartGlobalization();
            
            List<Task> toLoad = new();
            toLoad.Add(Task.Delay(Consts.SPALSHSCREEN_LOAD_TIME));
            toLoad.Add(Task.Run(() => lblStatusCarregamento.Invoke((MethodInvoker) 
                delegate { lblStatusCarregamento.Text = "Carregando..."; })));
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
