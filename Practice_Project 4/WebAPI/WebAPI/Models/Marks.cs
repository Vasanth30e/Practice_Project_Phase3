using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    [Table("Marks")]
    public class Marks
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        [StringLength(50)]
        public string StudentName { get; set;}
        [Required]
        [StringLength(50)]
        public string ClassName { get; set; }
        [Required]
        [StringLength(50)]
        public string SubjectName { get; set;}
        [Required]
        public int Mark { get; set;}
    }
}
