using Baser.Enum;
using SerializedConfig;
using SerializedConfig.Types;

namespace Baser
{
    public static class AppConfigurationManger
    {
        private static readonly ConfigurationModel configurationModel = new()
        {
          DatabaseConnection = new()
          {
              connectionString = string.Empty
          },
          LanguageSection = new()
          {
              langCode = 0 //PT-BR
          },
          userSection = new()
          {
              userName = string.Empty,
              userType = UserType.USU
          },
          printSection = new()
          {
              previewPrint = false
          }
        };

        private static ConfigManager<ConfigurationModel> _configManager { get; } = 
            new(Consts.CONFIG_FILE_PATH, SerializationFormat.Yaml, configurationModel);
        public static ConfigurationModel configManager
        {
            get => _configManager.configuration;
        }
        
        public static void SaveConfig()
        {
            _configManager.Save();
        }
        public static void LoadConfig()
        {
            _configManager.Load();
        }
    }
}