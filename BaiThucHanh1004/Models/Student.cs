using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BaiThucHanh1004.Models
{
    public class Student
    {
        [Key]
        public string StudentID{get; set;}
        public string StudentName{get; set;}
        public string FacultyID{get; set;}
        [ForeignKey("FacultyID")]
        public Faculty? Faculty{get; set;}
        public string Address{get; set;}
    }
}