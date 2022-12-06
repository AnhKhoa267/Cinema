using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
        }

    
        public DbSet<DoiBong> DoiBongs { get; set; }

        public DbSet<Lich> Lichs { get; set;}

        public DbSet<CauThu> CauThus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CauThu>().HasData(new CauThu
            {
                IdCT = 1,
                Ten = "LIONEL MESSI",
                SoAo = "10",
                ViTri="TienVe"
            });
            modelBuilder.Entity<CauThu>().HasData(new CauThu
            {
                IdCT = 2,
                Ten = "CRISTIANO RONALDO",
                SoAo = "7",
                ViTri = "TienVe"
            });
            modelBuilder.Entity<CauThu>().HasData(new CauThu
            {
                IdCT = 3,
                Ten = "CT-003",
                SoAo = "9",
                ViTri = "TienVe"
            });
            base.OnModelCreating(modelBuilder);

        }
    }
}
