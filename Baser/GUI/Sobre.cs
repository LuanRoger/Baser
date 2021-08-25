using System.Drawing;
using System.Drawing.Text;
using System.Reflection;
using System.Windows.Forms;
using Baser.Strings;
using GlobalStrings;

namespace Baser.GUI
{
    public partial class Sobre : Form
    {
        public Sobre()
        {
            InitializeComponent();
            
            LanguagesResouces.GetGlobalizationInstance().LangTextObserver += OnLangTextObserver;
        }

        private void OnLangTextObserver(object sender, UpdateModeEventArgs updatemodeeventargs)
        {
            Text = LanguagesResouces.GetGlobalizationInstance().SetText(0, 7);
            label4.Text = LanguagesResouces.GetGlobalizationInstance().SetText(0, 17);
        }

        private void Sobre_Load(object sender, System.EventArgs e)
        {
            PrivateFontCollection privateFont = new();
            privateFont.AddFontFile(Application.StartupPath + @"font\\Montserrat-ExtraBold.ttf");
            lblProgramName.Font = new(privateFont.Families[0], 20, FontStyle.Bold);

            lblProgramName.Text = Assembly.GetExecutingAssembly().GetName().Name;
            lblProgramVersion.Text = $"v{Assembly.GetExecutingAssembly().GetName().Version}";
        }
    }
}
