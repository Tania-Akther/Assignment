using System.ComponentModel.DataAnnotations;
namespace Assignment.Models
{
    public class Company
    {
        [Key]
        public int CompanyID { get; set; }
        [MaxLength(100)]
        public string CompanyName { get; set; } = string.Empty;
    }
}
