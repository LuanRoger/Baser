using System;

namespace Baser
{
    public static class Consts
    {
        public static string APP_FOLDER = 
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\LuanRoger\Baser\";

        public const string CONFIG_EXTENSION = ".yaml";
        public static string CONFIG_FILE_PATH = APP_FOLDER + "appsettings" + CONFIG_EXTENSION;

        public const int SPALSHSCREEN_LOAD_TIME = 2000;
    }
}