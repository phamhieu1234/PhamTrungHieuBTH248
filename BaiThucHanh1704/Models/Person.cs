using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BaiThucHanh1704.Models;

    public class Person
    {
        [Key]
        public string PersonID{get; set;}
        public string PersonName{get; set;}
        public string FacultyID{get; set;}
        [ForeignKey("FacultyID")]
        public Faculty? Faculty{get; set;}
        public string Addreess{get; set;}

    }
