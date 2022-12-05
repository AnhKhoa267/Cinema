﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models
{
    public class Category
    {
        [Key]
        public int RapId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string ? TenRap { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string DiaChi { get; set; } = "";
        [Column(TypeName = "nvarchar(50)")]
        public string Type { get; set; } = "Expense";
        [NotMapped]
        public string? TitleWithIcon
        {
            get
            {
                return this.TenRap;
            }
        }
        public string? TitleWithIcons
        {
            get
            {
                return this.DiaChi;
            }
        }


    }
}
