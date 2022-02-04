using System.Collections.Generic;
using System.Threading.Tasks;
using Baser.Enum;
using Baser.Managers.Configuration;
using Baser.Strings;
using GlobalStrings.Extensions;
using GlobalStrings.Globalization;
using GlobalStrings.Types;

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
        
        public static Task SaveLangToJson()
        {
            return globalization.SaveLanguageInfosAsync(Consts.LANGUAGE_FILE_PATH);
        }
        public static Task LoadLangToJson()
        {
            return globalization.LoadLanguageInfosAsync(Consts.LANGUAGE_FILE_PATH);
        }

        public static string ReturnGlobalizationText(string collectionCode, string key) => 
            globalization.SetText(collectionCode, key);
    }
}