using GlobalStrings;
using System.Collections.Generic;

namespace Baser.Strings
{
    public static class LanguagesResouces
    {
        private static Globalization<int, int, int> globalization { get; set; }
        private static List<LanguageInfo<int, int, int>> languageInfos = new();
        private static LanguageInfo<int, int, int> ptBrStrings = new(0);
        private static LanguageInfo<int, int, int> enStrings = new(1);

        private static Globalization<int, int, int> InitGlobalization()
        {
            InitPtBrLang();
            InitEnLanguage();

            return new(languageInfos, AppConfigurationManger.configManager.LanguageSection.langCode);
        }
        private static void InitPtBrLang()
        {
            ptBrStrings.textBookCollection = new()
            {
                { 0, new()
                {
                    {0, "Configurações"},
                    { 1, "Salvar" },
                    { 2, "Idioma" },
                    { 3, "Baser" },
                    { 4, "Inicio" },
                    { 5, "Mostrar lista" },
                    { 6, "Configurações" },
                    { 7, "Sobre" },
                    { 8, "Desconectar" },
                    { 9, "[F7] - Desconectar" },
                    { 10, "[F6] - Sair" },
                    { 11, "Usuário" },
                    { 12, "Senha" },
                    { 13, "Manter conectado" },
                    { 14, "Entrar" },
                    { 15, "Fechar" },
                    { 16, "String de conexão (SQL Server):" },
                    { 17, "Papel de parede: starline (Freepik)" }
                }}
            };

            languageInfos.Add(ptBrStrings);
        }
        private static void InitEnLanguage()
        {
            enStrings.textBookCollection = new()
            {
                { 0, new()
                {
                    {0, "Configuration"},
                    { 1, "Save" },
                    { 2, "Languages" },
                    { 3, "Baser" },
                    { 4, "Home" },
                    { 5, "Show list" },
                    { 6, "Configuration" },
                    { 7, "About" },
                    { 8, "Logoff" },
                    { 9, "[F7] - Logoff" },
                    { 10, "[F6] - Exit" },
                    { 11, "User" },
                    { 12, "Password" },
                    { 13, "Keep connected" },
                    { 14, "Enter" },
                    { 15, "Close" },
                    { 16, "Connection String (SQL Server):" },
                    { 17, "Wallpaper: starline (Freepik)" }
                }}
            };

            languageInfos.Add(enStrings);
        }

        public static Globalization<int, int, int> GetGlobalizationInstance()
        {
            globalization ??= InitGlobalization();
            
            return globalization;
        }
    }
}
