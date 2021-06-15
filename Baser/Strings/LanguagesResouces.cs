using GlobalStrings;
using System.Collections.Generic;
using System.Configuration;

namespace Baser.Strings
{
    public static class LanguagesResouces
    {
        private static Globalization globalization {get; set;}
        private static List<LanguageInfo> languageInfos = new();
        private static LanguageInfo ptBrStrings = new(0);
        private static LanguageInfo enStrings = new(1);

        private static Globalization InitGlobalization()
        {
            InitPtBrLang();
            InitEnLanguage();

            return new Globalization(languageInfos, int.Parse(ConfigurationManager.AppSettings["lang"]));
        }
        private static void InitPtBrLang()
        {
            ptBrStrings.textLangBook = new();
            ptBrStrings.textLangBook.Add(0, "Configurações");
            ptBrStrings.textLangBook.Add(1, "Salvar");
            ptBrStrings.textLangBook.Add(2, "Idioma");
            ptBrStrings.textLangBook.Add(16, "String de conexão (SQL Server):");

            ptBrStrings.textLangBook.Add(3, "Baser");
            ptBrStrings.textLangBook.Add(4, "Inicio");
            ptBrStrings.textLangBook.Add(5, "Mostrar lista");
            ptBrStrings.textLangBook.Add(6, "Configurações");
            ptBrStrings.textLangBook.Add(7, "Sobre");
            ptBrStrings.textLangBook.Add(8, "Desconectar");
            ptBrStrings.textLangBook.Add(9, "[F7] - Desconectar");
            ptBrStrings.textLangBook.Add(10, "[F6] - Sair");

            ptBrStrings.textLangBook.Add(11, "Usuário");
            ptBrStrings.textLangBook.Add(12, "Senha");
            ptBrStrings.textLangBook.Add(13, "Manter conectado");
            ptBrStrings.textLangBook.Add(14, "Entrar");
            ptBrStrings.textLangBook.Add(15, "Fechar");

            languageInfos.Add(ptBrStrings);
        }
        private static void InitEnLanguage()
        {
            enStrings.textLangBook = new();
            enStrings.textLangBook.Add(0, "Configuration");
            enStrings.textLangBook.Add(1, "Save");
            enStrings.textLangBook.Add(2, "Languages");
            enStrings.textLangBook.Add(16, "Connection String (SQL Server):");

            enStrings.textLangBook.Add(3, "Baser");
            enStrings.textLangBook.Add(4, "Home");
            enStrings.textLangBook.Add(5, "Mostrar lista");
            enStrings.textLangBook.Add(6, "Configuration");
            enStrings.textLangBook.Add(7, "About");
            enStrings.textLangBook.Add(8, "Logoff");
            enStrings.textLangBook.Add(9, "[F7] - Logoff");
            enStrings.textLangBook.Add(10, "[F6] - Exit");

            enStrings.textLangBook.Add(11, "User");
            enStrings.textLangBook.Add(12, "Password");
            enStrings.textLangBook.Add(13, "Keep connected");
            enStrings.textLangBook.Add(14, "Enter");
            enStrings.textLangBook.Add(15, "Close");

            languageInfos.Add(enStrings);
        }

        public static Globalization GetGlobalizationInstance()
        {
            if(globalization == null) return globalization = InitGlobalization();
            else return globalization;
        }
    }
}
