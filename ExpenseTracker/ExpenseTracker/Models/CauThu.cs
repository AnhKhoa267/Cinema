using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models
{
    public class CauThu
    {
        [Key]
        public int IdCT { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Ten { get; set; }
        [Column(TypeName = "nvarchar(5)")]
        public string SoAo { get; set; } = "";
        [Column(TypeName = "nvarchar(10)")]
        public string ViTri { get; set; } = "";
        [Column(TypeName = "nvarchar(10)")]
        public string Type { get; set; } = "Chinh";
        [NotMapped]
        public string? TEN
        {
            get
            {
                return this.Ten;
            }
        }
        public string? SOAO
        {
            get
            {
                return this.SoAo;
            }
        }
        public string? VITRI
        {
            get
            {
                return this.ViTri;
            }
        }
    }
}
