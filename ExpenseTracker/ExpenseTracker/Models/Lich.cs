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
        public string? TenPhim { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? TenRap { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string ? Giocongchieu { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Type { get; set; } = "Expense";
        [NotMapped]
        public string? TitleWithLich1
        {
            get
            {
                return this.TenPhim;
            }
        }
        public string? TitleWithLich2
        {
            get
            {
                return this.TenRap;
            }
        }
        public string? TitleWithLich3
        {
            get
            {
                return this.Giocongchieu;
            }
        }
    }
}
