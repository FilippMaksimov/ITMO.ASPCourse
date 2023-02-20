using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITMO.ASPCourse.MVC.ExamTask.Models
{
    public class ModelView
    {
        //Attributes for student table
        [Required(ErrorMessage ="Enter name")]
        public string StudentName { get; set; }
        [Required(ErrorMessage ="Enter Group number")]
        public int GroupNo { get; set; }
        [Required(ErrorMessage = "Enter Email address")]
        public string Email { get; set; }
        //Attributes for score table
        public DateTime ScoreDate { get; set; }

    }
}