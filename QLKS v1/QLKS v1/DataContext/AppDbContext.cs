using Microsoft.EntityFrameworkCore;
using QLKS_v1.Entities;
using System;
using System.Data;

namespace QLKS_v1.DataContext
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ComfirmEmail> comfirmEmails { get; set; }
        public DbSet<RefreshToken> refreshTokens { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<UserStatus> usersStatus { get; set; }
        public DbSet<Role> roles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KEN\\KEN; database = KS_v1; integrated security = sspi; encrypt = true; trustservercertificate = true; MultipleActiveResultSets=true");
        }


    }
}
