namespace WebApplication1.Models
{
    public class Lich
    {
        public string MaLich { get; set; }
        public string TenPhim { get; set; } = string.Empty;

        public int TongSuat { get; set; }
        public DateTime? NgayChieu { get; set; }


        public string IdRap { get; set; }
        public virtual DSRap? DSRap { get; set; }
    }
}
