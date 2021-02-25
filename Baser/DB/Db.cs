using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Baser.DB
{
    internal abstract class Db
    {
        protected static readonly SqlConnection connection = 
            new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString);

        public string DbStatus() => connection.State.ToString();
        #region Modificar conexão
        public void AbrirConexaoDb()
        {
            try { connection.Open(); }
            catch(Exception e)
            {
                MessageBox.Show($"Não foi possivel conectar-se com o banco de dados: {e.Message}","Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void FechaConecxaoDb() => connection.Close();
        #endregion
    }
}
