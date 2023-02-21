using System.ComponentModel.DataAnnotations;

namespace BaiThucHanh2002.Models
{
    public class Employee
    {
        [Key]
        public string? EmployeeID{get; set;}
      
        public string? EmployeeName{get; set;}
        public string? Age{get; set;}
    }
    
}