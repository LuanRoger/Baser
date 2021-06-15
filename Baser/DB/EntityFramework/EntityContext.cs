using Baser.DB.EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Baser.DB.EntityFramework
{
    class EntityContext : DbContext
    {
        public static string ConnectionStringsSqlServer {get; private set; } = ConfigurationManager
            .ConnectionStrings["SqlConnectionString"].ConnectionString;
        public DbSet<User> UserContext {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionStringsSqlServer);
        }
    }
}