using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ExpenseTracker.Models
{
    public class DoiBong
    {
        [Key]
        public string? MADOIBONG { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? TENQUOCGIA { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public int SOCAUTHU { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string HLV { get; set; } = "COMAT";
        [NotMapped]
        public string? TitleWithIcon
        {
            get
            {
                return this.TENQUOCGIA;
            }
        }
        public string? TitleWithIcons
        {
            get
            {
                return this.SOCAUTHU + "nguoi";
            }
        }
    }
}
