using System;
using System.Windows.Forms;
using Baser.Strings;

namespace Baser.GUI
{
    public partial class Configuracoes : Form
    {
        public Configuracoes()
        {
            InitializeComponent();
            CarregarConfiguracoes();

            LanguagesResouces.GetGlobalizationInstance().LangTextObserver += Configuracoes_LangTextObserver;
        }

        private void Configuracoes_LangTextObserver(object sender, GlobalStrings.UpdateModeEventArgs updateModeEventArgs)
        {
            label1.Text = LanguagesResouces.GetGlobalizationInstance().SetText(0, 2);
            label2.Text = LanguagesResouces.GetGlobalizationInstance().SetText(0, 16);
            btnSalvarConfiguracoes.Text = LanguagesResouces.GetGlobalizationInstance().SetText(0, 1);
            Text = LanguagesResouces.GetGlobalizationInstance().SetText(0, 0);
        }

        private void CarregarConfiguracoes()
        {
            cmbIdioma.SelectedIndex = AppConfigurationManger.configManager.LanguageSection.langCode;
            txtConnectionString.Text = AppConfigurationManger.configManager.DatabaseConnection.connectionString;
        }

        private void btnSalvarConfiguracoes_Click(object sender, EventArgs e)
        {
            AppConfigurationManger.configManager.LanguageSection = 
                AppConfigurationManger.configManager.LanguageSection with
            {
                langCode = cmbIdioma.SelectedIndex
            };
            AppConfigurationManger.configManager.DatabaseConnection = 
                AppConfigurationManger.configManager.DatabaseConnection with
            {
                connectionString = txtConnectionString.Text
            };

            AppConfigurationManger.SaveConfig();

            LanguagesResouces.GetGlobalizationInstance()
                .UpdateLang(AppConfigurationManger.configManager.LanguageSection.langCode);
        }
    }
}
