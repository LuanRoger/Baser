﻿using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Baser.Managers;
using ClosedXML.Excel;
using GlobalStrings.EventArguments;

namespace Baser.GUI
{
    public partial class Lista : Form
    {
        public Lista(DataTable data)
        {
            InitializeComponent();
            dgvLista.DataSource = data;

            try
            {
                PrivateFontCollection privateFont = new();
                privateFont.AddFontFile(Consts.FONT_LATO_BOLD);
                Font lato = new(privateFont.Families[0], 8, FontStyle.Bold);

                int columnQuantidade = dgvLista.ColumnCount;
                for (int i = 0; i < columnQuantidade; i++)
                {
                    dgvLista.Columns[i].DefaultCellStyle.Font = lato;
                }
            }
            catch
            {
                MessageBox.Show("Está faltando arquivos escenciais para abrir o programa, tente reistalar-lo novamente",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.GetCurrentProcess().Kill();
            }
        }

        private void Lista_Load(object sender, System.EventArgs e)
        {
            #region MenuClick
                mnuImprimirLista.Click += (_, _) =>
            {
                Imprimir.Imprimir imprimir = new();
                imprimir.ImprimirModelo(dgvLista);
            };
            mnuExportarExcel.Click += (_, _) =>
            {
                if (dgvLista.Rows.Count == 0)
                {
                    MessageBox.Show("Não há nada para exportar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                XLWorkbook workbook = CreateExcelSheet();
                
                SaveFileDialog saveFileDialog = new();
                saveFileDialog.Filter = "Arquivo XLSX (*.xlsx) |*.xlsx| Arquivo XLSM (*.xlsm) |*.xlsm";
                if (saveFileDialog.ShowDialog() != DialogResult.OK) return;


                workbook.SaveAs(saveFileDialog.FileName);
            };
            #endregion
            
            LanguageManager.SetGlobalizationObserver(GlobalizationOnLangTextObserver);
        }
        
        private void GlobalizationOnLangTextObserver(object sender, UpdateModeEventArgs updatemodeeventargs)
        {
            Text = LanguageManager.ReturnGlobalizationText("List", "WindowTitle");
        }
        
        private XLWorkbook CreateExcelSheet()
        {
            XLWorkbook workbook = new();
            IXLWorksheet worksheet = workbook.Worksheets.Add("Pagina 1");
            
            for (int c = 1; c != dgvLista.Columns.Count; c++)
            {
                worksheet.Cell(1, c).Style.Font.FontName = "Lato";
                worksheet.Cell(1, c).Style.Font.Bold = true;
                worksheet.Cell(1, c).Style.Fill.BackgroundColor = XLColor.DarkCyan;

                worksheet.Cell(1, c).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                worksheet.Cell(1, c).Style.Border.LeftBorderColor = XLColor.DarkGray;

                worksheet.Cell(1, c).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                worksheet.Cell(1, c).Style.Border.TopBorderColor = XLColor.DarkGray;

                worksheet.Cell(1, c).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                worksheet.Cell(1, c).Style.Border.RightBorderColor = XLColor.DarkGray;

                worksheet.Cell(1, c).Value = dgvLista.Columns[c - 1].HeaderText;
            }
            for (int r = 2; r != dgvLista.Rows.Count; r++)
            {
                for (int c = 1; c != dgvLista.Columns.Count; c++)
                {
                    worksheet.Cell(r, c).Style.Font.FontName = "Lato";

                    worksheet.Cell(r, c).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                    worksheet.Cell(r, c).Style.Border.LeftBorderColor = XLColor.DarkGray;

                    worksheet.Cell(r, c).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                    worksheet.Cell(r, c).Style.Border.TopBorderColor = XLColor.DarkGray;

                    worksheet.Cell(r, c).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                    worksheet.Cell(r, c).Style.Border.RightBorderColor = XLColor.DarkGray;

                    worksheet.Cell(r, c).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                    worksheet.Cell(r, c).Style.Border.BottomBorderColor = XLColor.DarkGray;

                    worksheet.Cell(r, c).Value = dgvLista.Rows[r - 2].Cells[c - 1].Value;
                }
            }
            return workbook;
        }
    }
}
