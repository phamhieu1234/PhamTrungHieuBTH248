
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaoCaoBaiTapLonNhom02.Models;

   public class SinhVien
   {
        [Key]
        [Display(Name ="Mã sinh viên")]
        [Required(ErrorMessage = "Phải nhập {0}")]
         [StringLength(250)]
        public string MaSV{get; set;}

        [Display(Name = "Tên")]
        [Required(ErrorMessage = "Phải nhập {0}")]
        [StringLength(250)]
         public string TenSV { get; set; }

        public string? MaNhom{get; set;}
       [ForeignKey("MaNhom")]
       public Nhom? Nhom{get; set;}
       
        public string? MaCathi{get; set;}
       [ForeignKey("MaCathi")]
       public Cathi? Cathi{get; set;}
   
}
