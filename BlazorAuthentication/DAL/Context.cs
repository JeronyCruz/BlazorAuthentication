using BlazorAuthentication.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorAuthentication.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<UserAccount> UserAccounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserAccount>().HasData(new List<UserAccount>()
            { 
                new UserAccount() {Id = 1, UserName = "Jerony", Password = "Venom01", Role = "Admin"},
                new UserAccount() {Id = 2, UserName = "Christopher", Password = "Carnage02", Role = "User"}
                });
        }
    }
}
