using Baser.Enum;
using GlobalStrings.Types;

namespace Baser.Strings
{
    public class PtBr : ILanguage
    {
        public LanguageInfo<LanguageCode, string, string> language { get; private set; }
        
        public void InitLanguage()
        {
            language = new(LanguageCode.PT_BR, new()
            {
                {"Home", new()
                {
                    {"MenuHome", "Inicio" },
                    {"SmenuShowList", "Mostrar lista" },
                    {"MenuConfiguration", "Configurações"},
                    {"MenuAbout", "Sobre" },
                    {"ButtonLogout", "Desconectar" },
                    {"ShortcutLogout", "[F7] - Desconectar" },
                    {"ShortcutExit", "[F6] - Sair" },
                }},
                {"Configuration", new()
                {
                    {"WindowTitle", "Configurações"},
                    {"LabelLanguage", "Idioma"},
                    {"LabelConnectionString", "String de conexão (SQL Server):"},
                    {"ButtonSave", "Salvar"}
                }},
                {"List", new()
                {
                    {"WindowTitle", "Lista"}
                }},
                {"Login", new()
                {
                    {"WindowTitle", "Entrar"},
                    {"LabelUsername", "Usuário"},
                    {"LabelPassword", "Senha"},
                    {"ButtonEnter", "Entrar"},
                    {"ButtonClose", "Fechar"}
                }},
                {"About", new()
                {
                    {"WindowTitle", "Sobre"},
                    {"LabelWallpaper", "Papel de parede: starline (Freepik)"}
                }},
                {"InCode", new()
                {
                    {"MessageBoxError", "Error"},
                    {"EssentialFiles", "Está faltando arquivos essenciais para inicialização do programa, tente reinstalá-lo novamente."},
                    {"SplashScreenLoading", "Carregando..."}
                }}
            });
        } 
    }
}