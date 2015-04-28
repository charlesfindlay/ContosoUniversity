using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        
        [Required]
        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage = "First Name can not be longer than 50 characters")]
        [Column("FirstName")]
        public string FirstMidName { get; set; }
        
        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get { return LastName + ", " + FirstMidName; } }
        
        public string Email { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }



    }
}