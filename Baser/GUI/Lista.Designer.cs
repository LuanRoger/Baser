
namespace Baser.GUI
{
    partial class Lista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mnuListaLivros = new System.Windows.Forms.MenuStrip();
            this.mnuImprimirLista = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.mnuExportarExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListaLivros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuListaLivros
            // 
            this.mnuListaLivros.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mnuListaLivros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuImprimirLista,
            this.mnuExportarExcel});
            this.mnuListaLivros.Location = new System.Drawing.Point(0, 0);
            this.mnuListaLivros.Name = "mnuListaLivros";
            this.mnuListaLivros.Size = new System.Drawing.Size(822, 24);
            this.mnuListaLivros.TabIndex = 1;
            this.mnuListaLivros.Text = "menuStrip1";
            // 
            // mnuImprimirLista
            // 
            this.mnuImprimirLista.Image = ((System.Drawing.Image)(resources.GetObject("mnuImprimirLista.Image")));
            this.mnuImprimirLista.Name = "mnuImprimirLista";
            this.mnuImprimirLista.Size = new System.Drawing.Size(28, 20);
            this.mnuImprimirLista.ToolTipText = "Imprimir";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dgvLista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLista.BackgroundColor = System.Drawing.Color.White;
            this.dgvLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLista.Location = new System.Drawing.Point(0, 24);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowTemplate.Height = 25;
            this.dgvLista.RowTemplate.ReadOnly = true;
            this.dgvLista.Size = new System.Drawing.Size(822, 472);
            this.dgvLista.TabIndex = 2;
            // 
            // mnuExportarExcel
            // 
            this.mnuExportarExcel.Image = global::Baser.Properties.Resources.page_excel;
            this.mnuExportarExcel.Name = "mnuExportarExcel";
            this.mnuExportarExcel.Size = new System.Drawing.Size(28, 20);
            this.mnuExportarExcel.ToolTipText = "Exportar como planilha";
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 496);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.mnuListaLivros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuListaLivros;
            this.Name = "Lista";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista";
            this.mnuListaLivros.ResumeLayout(false);
            this.mnuListaLivros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuListaLivros;
        private System.Windows.Forms.ToolStripMenuItem mnuImprimirLista;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.ToolStripMenuItem mnuExportarExcel;
    }
}