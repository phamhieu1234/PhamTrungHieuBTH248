using System.ComponentModel.DataAnnotations;
namespace BaiThucHanh2003.Models
{
    public class Employee
    {
        [Key]
        public string EmployeeID{get; set;} = default!;
        public string? EmployeeName{get; set;}
        public string? PhoneNumber{get;set;}

    }
}