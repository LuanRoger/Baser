using Baser.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Baser.DB.EntityFramework.Models
{
    [Table("User")]
    class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; init; }
        public string UserPassword { get; init; }
        public UserType UserType { get; init; }

        public static void CreateDefaultUser()
        {
            var dbContext = new EntityContext();

            if(dbContext.UserContext.Where(u => u.UserName == "admin").ToList().Count > 1) return;

            dbContext.UserContext.Add(new User {
                UserName = "admin",
                UserPassword = "admin",
                UserType = UserType.ADM
            });
            dbContext.SaveChanges();
        }
    }
}
