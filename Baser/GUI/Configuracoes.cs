using System;
using System.Windows.Forms;
using Baser.Enum;
using Baser.Managers;
using Baser.Managers.Configuration;
using GlobalStrings.EventArguments;

namespace Baser.GUI
{
    public partial class Configuracoes : Form
    {
        public Configuracoes()
        {
            InitializeComponent();
            CarregarConfiguracoes();

            LanguageManager.SetGlobalizationObserver(GlobalizationOnLangTextObserver);
            
        }

        private void GlobalizationOnLangTextObserver(object sender, UpdateModeEventArgs updatemodeeventargs)
        {
            Text = LanguageManager.ReturnGlobalizationText("Configuration", "WindowTitle");
            label1.Text = LanguageManager.ReturnGlobalizationText("Configuration", "LabelLanguage");
            label2.Text = LanguageManager.ReturnGlobalizationText("Configuration", "LabelConnectionString");
            btnSaveConfiguration.Text = LanguageManager.ReturnGlobalizationText("Configuration", "ButtonSave");
        }

        private void CarregarConfiguracoes()
        {
            cmbIdioma.SelectedIndex = (int)AppConfigurationManger.configManager.LanguageSection.langCode;
            txtConnectionString.Text = AppConfigurationManger.configManager.DatabaseConnection.connectionString;
        }

        private void btnSalvarConfiguracoes_Click(object sender, EventArgs e)
        {
            AppConfigurationManger.configManager.LanguageSection = 
                AppConfigurationManger.configManager.LanguageSection with
            {
                langCode = (LanguageCode)cmbIdioma.SelectedIndex
            };
            AppConfigurationManger.configManager.DatabaseConnection = 
                AppConfigurationManger.configManager.DatabaseConnection with
            {
                connectionString = txtConnectionString.Text
            };

            AppConfigurationManger.SaveConfig();

            LanguageManager.UpdateLanguage(AppConfigurationManger.configManager.LanguageSection.langCode);
        }
    }
}
