using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace Baser
{
    class Imprimir
    {
        private DGVPrinter printer = new();

        public void ImprimirModelo(DataGridView dataGrid)
        {
            printer.Title = "Baser";
            printer.TitleAlignment = StringAlignment.Center;
            printer.TitleFont = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point);

            printer.SubTitle = "Impressão";
            printer.SubTitleAlignment = StringAlignment.Center;
            printer.SubTitleFont = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

            printer.Footer = $"{DateTime.Now}";
            printer.FooterFont = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);

            printer.PageNumbers = ConfigurationManager.AppSettings["NumeroPaginas"] == "1";
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;

            if (ConfigurationManager.AppSettings["visualizarImpressao"] == "0") printer.PrintDataGridView(dataGrid);
            else printer.PrintPreviewDataGridView(dataGrid);
        }

    }
}
