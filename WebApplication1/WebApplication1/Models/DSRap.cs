namespace WebApplication1.Models
{
    public class DSRap
    {
        public string MaRap { get; set; }

        public string TenRap { get; set; } = string.Empty;
        public string DiaChi { get; set; } = string.Empty;

        public virtual IEnumerable<Lich> DSRaps { get; set; } = Enumerable.Empty<Lich>();
    }
}
