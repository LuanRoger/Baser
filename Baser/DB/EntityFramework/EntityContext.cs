using Baser.DB.EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace Baser.DB.EntityFramework
{
    class EntityContext : DbContext
    {
        public static string ConnectionStringsSqlServer {get; private set; } = 
            AppConfigurationManger.configManager.DatabaseConnection.connectionString;
        public DbSet<User> UserContext {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionStringsSqlServer);
        }
    }
}