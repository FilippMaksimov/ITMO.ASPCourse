using ITMO.ASPCourse.MVC.Lab02.Ex04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ITMO.ASPCourse.MVC.Lab02.Ex04.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            string res = ExePolim();
            return res;
        }

        public string ExePolim()
        {
            StringBuilder str = new StringBuilder();
            Shape[] sh =
            {
                new Triangle(1,2,3),
                new Circle(5),
                new Triangle(5,6,8)
            };
            foreach (Shape item in sh)
            {
                str.AppendFormat("Это фигура {0}", item.Name + "<p>");
            }
            return str.ToString();
        }
    }
}