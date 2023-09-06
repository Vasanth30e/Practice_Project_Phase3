using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmployeeMS.Models
{
    [Table("Department")]
    public class DeptMaster
    {
        [Key]
        public int DeptCode { get; set; }

        [Required]
        [StringLength(50)]
        public string DeptName { get; set; }
    }
}
