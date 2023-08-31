using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public int Code { get; set; }
        [MaxLength(100)]
        public string EmployeeName { get; set; } = string.Empty;
        [MaxLength(15)]
        public string PhoneNo { get; set; } = string.Empty;
        [MaxLength(250)]
        public string Address { get; set; } = string.Empty;
        public int CompanyID { get; set; }
        public int DepartmentID { get; set; }

        public Company Company { get; set; }
        public Department Department { get; set; }
    }
}
