using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Phase3Section3._34.Models
{
    public class StudentMetaData
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50)]
        [Display(Name = "Student Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Class is required")]
        [StringLength(5)]
        [Display(Name = "Which Class ")]
        public string Class { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(100)]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [StringLength(50)]
        [Display(Name = "Student Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
    }

}
