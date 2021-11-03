using Baser.DB.EntityFramework.Models;
using Baser.Managers.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Baser.DB.EntityFramework
{
    public class EntityContext : DbContext
    {
        private static readonly string ConnectionStringsSqlServer = 
            AppConfigurationManger.configManager.DatabaseConnection.connectionString;
        public DbSet<User> UserContext {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionStringsSqlServer);
        }
    }
}