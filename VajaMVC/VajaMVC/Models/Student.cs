using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VajaMVC.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Display (Name="Ime")]
        [Required(ErrorMessage ="Vnos imena je obvezen!")]
        public string StudentName { get; set; }
        [Display(Name = "Starost")]
        [Required(ErrorMessage ="Vnos starosti je obvezen!")]
        [Range(18,50, ErrorMessage="Neveljavna starost!")]
        public int Age { get; set; }
    }
}