﻿using System;
using System.Configuration;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Baser.GUI
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();

            PrivateFontCollection privateFont = new PrivateFontCollection();
            privateFont.AddFontFile(Application.StartupPath + @"font\\Montserrat-ExtraBold.ttf");
            privateFont.AddFontFile(Application.StartupPath + @"font\\Montserrat-ExtraLight.ttf");
            label1.Font = new Font(privateFont.Families[0], 20, FontStyle.Bold);
            label2.Font = new Font(privateFont.Families[1], 7, FontStyle.Regular);

            //Carregar
            lblStatusCarregamento.Text = "Fazendo login...";
            LoginApp();

            lblStatusCarregamento.Text = "Carregando...";
        }

        private void LoginApp()
        {
            var d = String.IsNullOrEmpty(ConfigurationManager.AppSettings["user"]);
            var c = ConfigurationManager.AppSettings["user"];
            if (!String.IsNullOrEmpty(ConfigurationManager.AppSettings["user"])) return;

            Login login = new();
            login.BringToFront();
            login.Show();
        }
    }
}
