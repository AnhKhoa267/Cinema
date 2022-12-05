using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace ExpenseTracker.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> context):base(context)
        {
        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<DSPhim> DSPhims  { get; set; }
        public DbSet<Lich> Lichs{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category
            {
                RapId = 1,
                TenRap = "AnDuongVuong",
                DiaChi = "639"
            });
            modelBuilder.Entity<DSPhim>().HasData(new DSPhim
            {
                PhimId = 1,
                TenPhim = "AnDuongVuong",
                ThoiLuong = 639
            });
            modelBuilder.Entity<Lich>().HasData(new Lich
            {
                LichId = 1,
                TenPhim = "AnDuongVuong",
                TenRap = "NhaHan",
                Giocongchieu = "113h00"
            });
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
