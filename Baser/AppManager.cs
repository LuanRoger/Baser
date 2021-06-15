using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using Baser.Strings;
using GlobalStrings;

namespace Baser
{
    public static class AppManager
    {
        public static void ReiniciarPrograma()
        {
            Process.Start(Application.StartupPath + Assembly.GetExecutingAssembly().GetName().Name + ".exe");
            Process.GetCurrentProcess().Kill();
        }
    }
}
