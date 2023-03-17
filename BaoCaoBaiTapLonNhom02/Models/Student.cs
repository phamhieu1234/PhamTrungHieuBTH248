using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaoCaoBaiTapLonNhom02.Models
{
    public class Student
    {
        [Key]
        [Required]
        public string? MaID{get; set;}
        [Required]
        public string? Ten{get; set;}
        [Required]
        public string?  MaNhom {get;set;}
         [ForeignKey("MaNhom")]
       public Nhom? Nhom{get; set;}
        public string?  MaCathi {get;set;}
         [ForeignKey("MaCathi")]
       public Cathi? Cathi{get; set;}


 }
}