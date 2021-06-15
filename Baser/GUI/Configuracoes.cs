using System;
using System.Configuration;
using System.Windows.Forms;
using Baser.DB.EntityFramework;
using Baser.Strings;

namespace Baser.GUI
{
    public partial class Configuracoes : Form
    {
        public static Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public Configuracoes()
        {
            InitializeComponent();
            CarregarConfiguracoes();

            LanguagesResouces.GetGlobalizationInstance().LangTextObserver += Configuracoes_LangTextObserver;
        }

        private void Configuracoes_LangTextObserver(object sender, GlobalStrings.UpdateModeEventArgs updateModeEventArgs)
        {
            label1.Text = LanguagesResouces.GetGlobalizationInstance().SetText(2);
            label2.Text = LanguagesResouces.GetGlobalizationInstance().SetText(16);
            btnSalvarConfiguracoes.Text = LanguagesResouces.GetGlobalizationInstance().SetText(1);
            Text = LanguagesResouces.GetGlobalizationInstance().SetText(0);
        }

        private void CarregarConfiguracoes()
        {
            cmbIdioma.SelectedIndex = int.Parse(ConfigurationManager.AppSettings["lang"]);
            txtConnectionString.Text = EntityContext.ConnectionStringsSqlServer;
        }

        private void btnSalvarConfiguracoes_Click(object sender, EventArgs e)
        {
            config.AppSettings.Settings["lang"].Value = cmbIdioma.SelectedIndex.ToString();
            config.ConnectionStrings.ConnectionStrings["SqlConnectionString"].ConnectionString = txtConnectionString.Text;

            config.Save();
            ConfigurationManager.RefreshSection("appSettings");

            LanguagesResouces.GetGlobalizationInstance().UpdateLang(int.Parse(ConfigurationManager.AppSettings["lang"]));
        }
    }
}
