namespace WebApplication1.Models
{
    public class DSPhim
    {
        public string MaPhim { get; set; }
        public string TenPhim { get; set; } = string.Empty;

        public string Suat { get; set; } = string.Empty;
        public int ThoiLuong { get; set; }

        public DateTime? NgayChieu { get; set; }


    }
}
