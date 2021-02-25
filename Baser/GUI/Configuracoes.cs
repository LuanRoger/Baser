using System;
using System.Configuration;
using System.Windows.Forms;

namespace Baser.GUI
{
    public partial class Configuracoes : Form
    {
        public static Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public Configuracoes()
        {
            InitializeComponent();
        }

        private void btnSalvarConfiguracoes_Click(object sender, EventArgs e) => throw new NotImplementedException();
    }
}
