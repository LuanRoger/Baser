using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Baser.GUI
{
    public partial class ListaPesquisa : Form
    {
        public ListaPesquisa(DataTable data)
        {
            InitializeComponent();
            dgvLista.DataSource = data;

            try
            {
                PrivateFontCollection privateFont = new PrivateFontCollection();
                privateFont.AddFontFile(Application.StartupPath + @"font\Lato-Bold.ttf");
                Font lato = new Font(privateFont.Families[0], 8, FontStyle.Bold);

                int columnQuantidade = dgvLista.ColumnCount;
                for (int i = 0; i < columnQuantidade; i++)
                {
                    dgvLista.Columns[i].DefaultCellStyle.Font = lato;
                }
            }
            catch
            {
                MessageBox.Show("Está faltando arquivos escenciais para abrir o programa, tente reistalar-lo novamente_",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.GetCurrentProcess().Kill();
            }

            mnuImprimirLista.Click += (sender, e) =>
            {
                Imprimir imprimir = new();
                imprimir.ImprimirModelo(dgvLista);
            };
        }
    }
}
