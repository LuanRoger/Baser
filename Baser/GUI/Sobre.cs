using System.Drawing;
using System.Drawing.Text;
using System.Reflection;
using System.Windows.Forms;
using Baser.Managers;
using GlobalStrings.EventArguments;

namespace Baser.GUI
{
    public partial class Sobre : Form
    {
        public Sobre()
        {
            InitializeComponent();
        }

        private void GlobalizationOnLangTextObserver(object sender, UpdateModeEventArgs updatemodeeventargs)
        {
            Text = LanguageManager.ReturnGlobalizationText("About", "WindowTitle");
            label4.Text = LanguageManager.ReturnGlobalizationText("About", "LabelWallpaper");
        }

        private void Sobre_Load(object sender, System.EventArgs e)
        {
            PrivateFontCollection privateFont = new();
            privateFont.AddFontFile(Consts.FONT_MONTSERRAT_EXTRABOLD);
            lblProgramName.Font = new(privateFont.Families[0], 20, FontStyle.Bold);

            lblProgramName.Text = Assembly.GetExecutingAssembly().GetName().Name;
            lblProgramVersion.Text = $"v{Assembly.GetExecutingAssembly().GetName().Version}";
            
            LanguageManager.SetGlobalizationObserver(GlobalizationOnLangTextObserver);
        }
    }
}
