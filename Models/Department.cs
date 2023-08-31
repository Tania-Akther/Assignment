using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }
        [MaxLength(100)]
        public string DepartmentName { get; set; } = string.Empty;
        [ForeignKey("Company")]
        public int CompanyID { get; set; }

        public Company Company { get; set; }
    }
}
