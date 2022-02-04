using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace Baser.Managers
{
    public static class AppManager
    {
        public static void RestartProgram()
        {
            Process.Start(Application.StartupPath + Assembly.GetExecutingAssembly().GetName().Name + ".exe");
            Process.GetCurrentProcess().Kill();
        }
        
        public static void CreateAppDirectory()
        {
            Directory.CreateDirectory(Consts.APP_FOLDER);
        }
        
        public static void DownloadFonts()
        {
            Directory.CreateDirectory(Consts.FONT_FOLDER);
            
            using WebClient webClient = new();
            
            foreach (string font in Consts.FONTS)
            {
                string fontPath = Consts.FONT_FOLDER + font;
                
                if(!File.Exists(fontPath))
                    webClient.DownloadFile(Consts.FONT_DOWNLOAD + font, Consts.FONT_FOLDER + font);
            }
        }
    }
}
