using DmitrievDenisKt_31_20.DataBase.Configurations;
using DmitrievDenisKt_31_20.Models;
using Microsoft.EntityFrameworkCore;

namespace DmitrievDenisKt_31_20.DataBase
{
    public class DmitrievDbContext : DbContext
    {
        internal DbSet<Student> Students { get; set; }
        internal DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
        }
        public DmitrievDbContext(DbContextOptions<DmitrievDbContext> options) : base(options) { }
    }
}
