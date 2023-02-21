using System.ComponentModel.DataAnnotations;

namespace BaiThucHanh2002.Models
{
    public class Student
    {
        [Key]
        public string? StudentID{get; set;}
      
        public string? StudentName{get; set;}
        public string? Age{get; set;}
    }
    
}