using System.ComponentModel;

namespace Baser.GUI
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.txtLoginSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEntrarLogin = new System.Windows.Forms.Button();
            this.btnFecharLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.Location = new System.Drawing.Point(13, 31);
            this.txtLoginUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.Size = new System.Drawing.Size(233, 23);
            this.txtLoginUsuario.TabIndex = 0;
            // 
            // txtLoginSenha
            // 
            this.txtLoginSenha.Location = new System.Drawing.Point(14, 75);
            this.txtLoginSenha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLoginSenha.Name = "txtLoginSenha";
            this.txtLoginSenha.PasswordChar = '*';
            this.txtLoginSenha.Size = new System.Drawing.Size(233, 23);
            this.txtLoginSenha.TabIndex = 2;
            this.txtLoginSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoginSenha_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Senha:";
            // 
            // btnEntrarLogin
            // 
            this.btnEntrarLogin.Location = new System.Drawing.Point(12, 118);
            this.btnEntrarLogin.Name = "btnEntrarLogin";
            this.btnEntrarLogin.Size = new System.Drawing.Size(75, 23);
            this.btnEntrarLogin.TabIndex = 10;
            this.btnEntrarLogin.Text = "Entrar";
            this.btnEntrarLogin.UseVisualStyleBackColor = true;
            this.btnEntrarLogin.Click += new System.EventHandler(this.btnEntrarLogin_Click);
            // 
            // btnFecharLogin
            // 
            this.btnFecharLogin.Location = new System.Drawing.Point(169, 118);
            this.btnFecharLogin.Name = "btnFecharLogin";
            this.btnFecharLogin.Size = new System.Drawing.Size(75, 23);
            this.btnFecharLogin.TabIndex = 11;
            this.btnFecharLogin.Text = "Fechar";
            this.btnFecharLogin.UseVisualStyleBackColor = true;
            this.btnFecharLogin.Click += new System.EventHandler(this.btnFecharLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(256, 146);
            this.Controls.Add(this.btnFecharLogin);
            this.Controls.Add(this.btnEntrarLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLoginSenha);
            this.Controls.Add(this.txtLoginUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.TextBox txtLoginUsuario;
        private System.Windows.Forms.TextBox txtLoginSenha;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEntrarLogin;
        private System.Windows.Forms.Button btnFecharLogin;
    }
}