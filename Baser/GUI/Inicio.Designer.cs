
namespace Baser.GUI
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMostrarLista = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConfiguracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTempo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSairConta = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tmrInicio = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrincipal,
            this.mnuConfiguracoes,
            this.mnuSobre});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(714, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMostrarLista});
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(48, 20);
            this.mnuPrincipal.Text = "Inicio";
            // 
            // mnuMostrarLista
            // 
            this.mnuMostrarLista.Name = "mnuMostrarLista";
            this.mnuMostrarLista.Size = new System.Drawing.Size(166, 22);
            this.mnuMostrarLista.Text = "Mostrar lista base";
            // 
            // mnuConfiguracoes
            // 
            this.mnuConfiguracoes.Name = "mnuConfiguracoes";
            this.mnuConfiguracoes.Size = new System.Drawing.Size(96, 20);
            this.mnuConfiguracoes.Text = "Configurações";
            // 
            // mnuSobre
            // 
            this.mnuSobre.Name = "mnuSobre";
            this.mnuSobre.Size = new System.Drawing.Size(49, 20);
            this.mnuSobre.Text = "Sobre";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTempo,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 454);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(714, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTempo
            // 
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(566, 17);
            this.lblTempo.Spring = true;
            this.lblTempo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(76, 17);
            this.toolStripStatusLabel2.Text = "[F7] - Logout";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(57, 17);
            this.toolStripStatusLabel1.Text = "[F6] - Sair";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::Baser.Properties.Resources.WallpaperInicio;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnSairConta, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUsuario, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(714, 430);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnSairConta
            // 
            this.btnSairConta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSairConta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSairConta.Image = ((System.Drawing.Image)(resources.GetObject("btnSairConta.Image")));
            this.btnSairConta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSairConta.Location = new System.Drawing.Point(3, 404);
            this.btnSairConta.Name = "btnSairConta";
            this.btnSairConta.Size = new System.Drawing.Size(53, 23);
            this.btnSairConta.TabIndex = 0;
            this.btnSairConta.Text = "Sair";
            this.btnSairConta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSairConta.UseVisualStyleBackColor = true;
            this.btnSairConta.Click += new System.EventHandler(this.btnSairConta_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(62, 408);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(3, 0, 3, 7);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(47, 15);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "usuario";
            // 
            // tmrInicio
            // 
            this.tmrInicio.Enabled = true;
            this.tmrInicio.Interval = 1000;
            this.tmrInicio.Tick += new System.EventHandler(this.tmrInicio_Tick);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 476);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baser";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Inicio_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuConfiguracoes;
        private System.Windows.Forms.ToolStripMenuItem mnuSobre;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTempo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer tmrInicio;
        private System.Windows.Forms.Button btnSairConta;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ToolStripMenuItem mnuMostrarLista;
    }
}

