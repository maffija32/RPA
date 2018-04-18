using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vaja111.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        [Display(Name="Ime")]
        [Required(ErrorMessage = "Nvjm")]
        public string StudentName { get; set; }
        [Display(Name = "Starost")]
        [Range(18,50,ErrorMessage = "Napačna starost")]
        public int Age { get; set; }
    }
}