using System.ComponentModel.DataAnnotations;
namespace BaiThucHanh1704.Models;

    public class Employee
    {
        [Key]
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }

    }
