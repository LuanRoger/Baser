using System;

namespace Baser
{
    public static class Consts
    {
        public static string APP_FOLDER = 
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\LuanRoger\Baser\";

        public const string CONFIG_EXTENSION = ".json";
        public static string CONFIG_FILE_PATH = APP_FOLDER + "appsettings" + CONFIG_EXTENSION;
        
        public static string LANGUAGE_FILE_PATH = APP_FOLDER + "languages.json";
        
        public static string[] FONTS = { "Montserrat-ExtraBold.ttf", "Montserrat-ExtraLight.ttf", "Lato-Bold.ttf"};
        public static string FONT_FOLDER = APP_FOLDER + @"font\";
        public static string FONT_MONTSERRAT_EXTRABOLD = FONT_FOLDER + FONTS[0];
        public static string FONT_MONTSERRAT_EXTRALIGHT = FONT_FOLDER + FONTS[1];
        public static string FONT_LATO_BOLD = FONT_FOLDER + FONTS[2];
        
        public const string FONT_DOWNLOAD = "https://github.com/LuanRoger/Baser/raw/master/Baser/assets/font/";

        public const int SPALSHSCREEN_LOAD_TIME = 2000;
    }
}