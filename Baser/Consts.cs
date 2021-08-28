using System;

namespace Baser
{
    public static class Consts
    {
        public static string APP_FOLDER = 
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\LuanRoger\Baser\";

        public const string CONFIG_EXTENSION = ".yaml";
        public static string CONFIG_FILE_PATH = APP_FOLDER + "appsettings" + CONFIG_EXTENSION;

        public static string FONT_FOLDER = APP_FOLDER + @"font\";
        public static string FONT_MONTSERRAT_EXTRABOLD = FONT_FOLDER + "Montserrat-ExtraBold.ttf";
        public static string FONT_MONTSERRAT_EXTRALIGHT = FONT_FOLDER + "Montserrat-ExtraLight.ttf";
        public static string FONT_LATO_BOLD = FONT_FOLDER + "Lato-Bold.ttf";

        public const int SPALSHSCREEN_LOAD_TIME = 2000;
    }
}