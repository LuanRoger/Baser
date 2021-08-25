using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Baser
{
    public static class AppManager
    {
        public static void ReiniciarPrograma()
        {
            Process.Start(Application.StartupPath + Assembly.GetExecutingAssembly().GetName().Name + ".exe");
            Process.GetCurrentProcess().Kill();
        }
        
        public static void CreateAppDirectory()
        {
            Directory.CreateDirectory(Consts.APP_FOLDER);
        }
    }
}
