using System.ComponentModel.DataAnnotations;
namespace BaoCaoBaiTapLonNhom02.Models
{
    public class Cathi
    {
        [Key]
        public string? MaCathi{get; set;}
        public string? ThoigianCathi{get; set;}
    }
}