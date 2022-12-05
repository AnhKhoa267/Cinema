using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models
{
    public class DSPhim
    {
        [Key]
        public int PhimId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? TenPhim { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public int ThoiLuong { get; set; } 
        [Column(TypeName = "nvarchar(50)")]
        public string Type { get; set; } = "Expense";
        [NotMapped]
        public string? TitleWithPhim
        {
            get
            {
                return this.TenPhim;
            }
        }
        public string? TitleWithPhims
        {
            get
            {
                return this.ThoiLuong + "phut";
            }
        }
    }
}
