using System.Drawing;
using System.Drawing.Text;
using System.Reflection;
using System.Windows.Forms;

namespace Baser.GUI
{
    public partial class Sobre : Form
    {
        public Sobre()
        {
            InitializeComponent();

            PrivateFontCollection privateFont = new PrivateFontCollection();
            privateFont.AddFontFile(Application.StartupPath + @"font\\Montserrat-ExtraBold.ttf");
            lblProgramName.Font = new Font(privateFont.Families[0], 20, FontStyle.Bold);

            lblProgramName.Text = Assembly.GetExecutingAssembly().GetName().Name;
            lblProgramVersion.Text = $"v{Assembly.GetExecutingAssembly().GetName().Version}";
        }
    }
}
