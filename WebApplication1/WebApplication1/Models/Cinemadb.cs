using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class Cinemadb:DbContext
    {
        public Cinemadb(DbContextOptions<Cinemadb> context) : base(context)
        {

        }

        public DbSet<DSRap> dSRaps { get; set; }
        public DbSet<DSPhim> dSPhims { get; set; }
        public DbSet<Lich> liches { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DSRap>().HasData(new DSRap
            {
                MaRap = "MR1",
                TenRap = "Kinh Duong Vuong",
                DiaChi = "1 Kinh Duong Vuong",
            });
            modelBuilder.Entity<DSPhim>().HasData(new DSPhim
            {
                MaPhim = "MP1",
                TenPhim = "Jujutsu Kaisen",
                Suat = "2h30",
                ThoiLuong = 120,
                NgayChieu = DateTime.Now
            });
            modelBuilder.Entity<Lich>().HasData(new Lich
            {
                MaLich = "MP1",
                TenPhim = "Jujutsu Kaisen",
                TongSuat = 10,
                NgayChieu = DateTime.Now,
                IdRap = "Rap-01"
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
