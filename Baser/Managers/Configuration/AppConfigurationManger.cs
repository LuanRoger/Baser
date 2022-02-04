using System.IO;
using Baser.Enum;
using SerializedConfig;
using SerializedConfig.Types.Serialization;

namespace Baser.Managers.Configuration
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
              langCode = LanguageCode.PT_BR
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
            new(Consts.CONFIG_FILE_PATH, SerializationFormat.Json, configurationModel);
        public static ConfigurationModel configManager => _configManager.configuration;

        public static void SaveConfig() => _configManager.Save();
        public static void LoadOrCreateConfig()
        {
            if (File.Exists(Consts.CONFIG_FILE_PATH)) 
                _configManager.Load();
            else SaveConfig();
        }
    }
}