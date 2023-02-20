using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Web;

namespace ITMO.ASPCourse.MVC.ExamTask.Models
{
    public class SelectSubject
    {
        public Dictionary<int, string>Subject { get; set; }
        public SelectSubject()
        {
            Subject = new Dictionary<int, string>()
            {
               {0, "sd" }
            };
        }
    }
}