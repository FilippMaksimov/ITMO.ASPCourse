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
        public string StudentName { get; set; }
        [Required(ErrorMessage ="Enter Group number")]
        public int GroupNo { get; set; }
        [Required(ErrorMessage = "Enter Email address")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + 
         @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage ="Email is not valid")]
        public string Email { get; set; }

    }
    public class ScoreMetadata
    {
        [Range(0,100)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Only Digits")]
        public Nullable<int> ScoreResult { get; set; }
    }
}