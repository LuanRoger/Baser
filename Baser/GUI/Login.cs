using System;
using System.Windows.Forms;
using System.Configuration;
using Baser.DB.EntityFramework;
using Baser.Strings;
using Baser.DB.EntityFramework.Models;
using System.Linq;

namespace Baser.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            User.CreateDefaultUser();
            LanguagesResouces.GetGlobalizationInstance().LangTextObserver += Login_LangTextObserver;
            LanguagesResouces.GetGlobalizationInstance().StartGlobalization();
        }

        private void Login_LangTextObserver(object sender, GlobalStrings.UpdateModeEventArgs updateModeEventArgs)
        {
            label1.Text = LanguagesResouces.GetGlobalizationInstance().SetText(11);
            label2.Text = LanguagesResouces.GetGlobalizationInstance().SetText(12);
            btnEntrarLogin.Text = LanguagesResouces.GetGlobalizationInstance().SetText(14);
            btnFecharLogin.Text = LanguagesResouces.GetGlobalizationInstance().SetText(15);
        }

        private void btnFecharLogin_Click(object sender, EventArgs e) => Application.Exit();
        
        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtLoginUsuario.Text.Trim();
            string senha = txtLoginSenha.Text.Trim();
            User user;

            //Atenção a senha não é verificada
            if (Verificadores.VerificarStrings(usuario, senha))
            {
                MessageBox.Show("Preencha os campos para continuar", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using(var dbContext = new EntityContext())
            {
                try
                {
                    user = dbContext.UserContext.First(u => u.UserName == usuario && u.UserPassword == senha);
                }
                catch
                {
                    MessageBox.Show("Usuário ou senha icorreto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //Salvar usuário para não precisar logar novamente
            Configuracoes.config.AppSettings.Settings["user"].Value = usuario;
            Configuracoes.config.AppSettings.Settings["userType"].Value = user.UserType.ToString();
            Configuracoes.config.Save();

            AppManager.ReiniciarPrograma();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e) => Environment.Exit(0);

        private void txtLoginSenha_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Enter:
                    btnEntrarLogin.PerformClick();
                    break;
            }
        }
    }
}