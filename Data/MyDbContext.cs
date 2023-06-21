using Microsoft.EntityFrameworkCore;
using WebAPI_Core_Test_DesignDb.Data.Configurations;
using WebAPI_Core_Test_DesignDb.Models;

namespace WebAPI_Core_Test_DesignDb.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new WardConfiguration());
        }
        #region DbSet
        public DbSet<User> Users { get; set; }
        public DbSet<Ward> Wards { get; set; }
        #endregion
    }

}
