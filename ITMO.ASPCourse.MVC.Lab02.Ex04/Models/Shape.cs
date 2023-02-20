using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITMO.ASPCourse.MVC.Lab02.Ex04.Models
{
    public class Shape
    {
        public double St { get; set; }
        virtual public string Name
        {
            get { return String.Format("\"Фигура\""); }
        }
    }
}