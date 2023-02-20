using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ITMO.ASPCourse.MVC.ExamTask.Models
{

    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {

    }

    [MetadataType(typeof(ScoreMetadata))]
    public partial class Score
    {

    }
}