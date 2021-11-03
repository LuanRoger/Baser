using Baser.Enum;
using GlobalStrings;

namespace Baser.Strings
{
    public class EnUs : ILanguage
    {
        public LanguageInfo<LanguageCode, string, string> language { get; private set; }

        public void InitLanguage()
        {
            language = new(LanguageCode.EN_US, new()
            {
                {"Home", new()
                {
                    {"MenuHome", "Home" },
                    {"SmenuShowList", "Show list" },
                    {"MenuConfiguration", "Configurations"},
                    {"MenuAbout", "About" },
                    {"ButtonLogout", "Logout" },
                    {"ShortcutLogout", "[F7] - Logout" },
                    {"ShortcutExit", "[F6] - Exit" },
                }},
                {"Configuration", new()
                {
                    {"WindowTitle", "Configuration"},
                    {"LabelLanguage", "Language"},
                    {"LabelConnectionString", "Connection string (SQL Server):"},
                    {"ButtonSave", "Save"}
                }},
                {"List", new()
                {
                    {"WindowTitle", "List"}
                }},
                {"Login", new()
                {
                    {"WindowTitle", "Login"},
                    {"LabelUsername", "Username"},
                    {"LabelPassword", "Password"},
                    {"ButtonEnter", "Login"},
                    {"ButtonClose", "Close"}
                }},
                {"About", new()
                {
                    {"WindowTitle", "About"},
                    {"LabelWallpaper", "Wallpaper: starline (Freepik)"}
                }},
                {"InCode", new()
                {
                    {"MessageBoxError", "Error"},
                    {"EssentialFiles", "Missing essential files for program startup, try to reinstall."},
                    {"SplashScreenLoading", "Loading..."}
                }}
            });
        }
    }
}