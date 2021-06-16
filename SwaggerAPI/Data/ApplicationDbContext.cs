using Microsoft.AspNet.Identity.EntityFramework;
using SwaggerAPI.Models;
using System.Data.Entity;

namespace SwaggerAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
          : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Item> Items { get; set; }
    }
}