using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baser.Managers;
using Baser.Managers.Configuration;

namespace Baser.GUI
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            
            AppManager.CreateAppDirectory();
            AppConfigurationManger.LoadOrCreateConfig();
            LanguageManager.Init();

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
                MessageBox.Show(LanguageManager.ReturnGlobalizationText("InCode", "EssentialFiles"),
                    LanguageManager.ReturnGlobalizationText("InCode", "MessageBoxError"),
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

            List<Task> toLoad = new();
            toLoad.Add(Task.Delay(Consts.SPALSHSCREEN_LOAD_TIME));
            toLoad.Add(Task.Run(() => lblStatusCarregamento.Invoke((MethodInvoker) 
                delegate { lblStatusCarregamento.Text = LanguageManager.ReturnGlobalizationText("InCode", "SplashScreenLoading");})));
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
