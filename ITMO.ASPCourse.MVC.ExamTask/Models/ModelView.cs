using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITMO.ASPCourse.MVC.ExamTask.Models
{
    public class StudentMetadata
    {
        //Attributes for student table
        [Required(ErrorMessage ="Enter name")]

        [RegularExpression(@"^[A-Z][a-z]*\s[A-Z][a-z]*", ErrorMessage ="Incorect Format. Name and Surename must start with big letters and this field must not containt digits")]
        [StringLength(40, ErrorMessage = "Too long format")]
        public string StudentName { get; set; }
        [Required(ErrorMessage ="Enter Group number")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage ="Must be digits")]
        public int GroupNo { get; set; }
        [Required(ErrorMessage = "Enter Email address")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + 
         @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage ="Email is not valid")]
        public string Email { get; set; }

    }
    public class ScoreMetadata
    {
        [Required(ErrorMessage ="Enter Score Result")]
        [Range(0,100)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Only Digits")]
        public Nullable<int> ScoreResult { get; set; }
        [Required(ErrorMessage ="Enter date as follows")]
        [DataType(DataType.Date, ErrorMessage ="Must be date format")]
        public Nullable<System.DateTime> ScoreDate { get; set; }
    }
}