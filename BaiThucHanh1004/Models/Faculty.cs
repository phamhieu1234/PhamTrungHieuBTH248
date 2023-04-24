using System.ComponentModel.DataAnnotations;
namespace BaiThucHanh1004.Models;

    public class Faculty
    {
        [Key]
        public string FacultyID{get; set;}
         public string FacultyName{get; set;}
    }
