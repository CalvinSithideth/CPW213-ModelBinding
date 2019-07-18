using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsAndModelBinding.Models
{
    /// <summary>
    /// Represents an individual student
    /// </summary>
    public class Student
    {
        public int StudentID { get; set; }

        /// <summary>
        /// The legal first and last name
        /// ex. J Doe
        /// </summary>
        [Required(ErrorMessage = "Gimme that name!")] // Make required - change ErrMsg on view
        [Display(Name = "Full Legal Name")] // Changes the label on a view
        public string FullName { get; set; }

        // Max 30 just for demo
        [StringLength(30, MinimumLength = 5)] // Set max length of input
        public string HomeAddress { get; set; }

        /// <summary>
        /// The program the student intends to
        /// complete
        /// </summary>
        [Required]
        [Display(Name = "Choose Program")]
        public string ProgramOfChoice { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set; }
    }
}
