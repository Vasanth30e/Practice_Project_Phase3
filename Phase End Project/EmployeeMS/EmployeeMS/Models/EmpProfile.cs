using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmployeeMS.Models
{
    [Table("Employee")]
    public class EmpProfile
    {
        [Key]
        public int EmpCode { get; set; }

        [Required]
        [StringLength(100)]
        public string EmpName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        public int DeptCode { get; set; }

        [ForeignKey("DeptCode")]
        public virtual DeptMaster DeptMaster { get; set; }
    }
}
