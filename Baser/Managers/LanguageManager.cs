using System.Collections.Generic;
using Baser.Enum;
using Baser.Managers.Configuration;
using Baser.Strings;
using GlobalStrings;
using GlobalStrings.Globalization;

namespace Baser.Managers
{
    public static class LanguageManager
    {
        private static Globalization<LanguageCode, string, string> globalization { get; set; }
        private static List<LanguageInfo<LanguageCode, string, string>> languages { get; set; } = new();
        
        public static void Init()
        {
            PtBr ptBr = new();
            EnUs enUs = new();
            ptBr.InitLanguage();
            enUs.InitLanguage();
            
            languages.Add(ptBr.language);
            languages.Add(enUs.language);
            
            InitGlobalization();
        }

        private static void InitGlobalization()
        {
            globalization = new(languages, AppConfigurationManger.configManager.LanguageSection.langCode);
            globalization.StartGlobalization();
        }
        
        public static void SetGlobalizationObserver(Globalization<LanguageCode, string, string>.LangTextObserverEventHandler
            langTextObserverEventHandler)
        {
            globalization.LangTextObserver += langTextObserverEventHandler;
            globalization.SyncStrings();
        }
        public static void UpdateLanguage(LanguageCode newLanguageCode) => globalization.UpdateLang(newLanguageCode);

        public static string ReturnGlobalizationText(string collectionCode, string key) => 
            globalization.SetText(collectionCode, key);
    }
}