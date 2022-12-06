using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ExpenseTracker.Models
{
    public class Lich
    {
        [Key]
        public int LichId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? TenDoi1 { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? TenDoi2 { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? SAN { get; set; }
        [Column(TypeName = "nvarchar(50)")]

        public string Type { get; set; } = "Dang dien ra";
        [NotMapped]
        public string? TitleWithLich1
        {
            get
            {
                return this.TenDoi1;
            }
        }
        public string? TitleWithLich2
        {
            get
            {
                return this.TenDoi2;
            }
        }
        public string? TitleWithLich3
        {
            get
            {
                return this.SAN;
            }
        }
    }
}

