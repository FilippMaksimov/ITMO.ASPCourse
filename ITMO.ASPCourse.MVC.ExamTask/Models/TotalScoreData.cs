using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITMO.ASPCourse.MVC.ExamTask.Models
{
    public class TotalScoreData
    {
        public int StudentID { get; set; }
        public int TotalScore { get; set; }
    }
    public class GroupedScoreData
    {
        public IReadOnlyList<TotalScoreData> Items { get; set; }
        public int Total { get; set; }
    }
}