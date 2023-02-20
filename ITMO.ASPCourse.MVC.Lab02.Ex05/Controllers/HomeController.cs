using ITMO.ASPCourse.MVC.Lab02.Ex05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ITMO.ASPCourse.MVC.Lab02.Ex05.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            //string res = ExeCollection();
            string res = ExeTriCollection();
            return res;
        }
        public string ExeCollection()
        {
            List<Circle> cirs = new List<Circle>
            {
                new Circle(12),
                new Circle(5),
                new Circle(15),
                new Circle(6)
            };
            cirs.Add(new Circle(7));
            cirs.Sort();
            StringBuilder str = new StringBuilder();
            foreach (Shape item in cirs)
            {
                str.AppendFormat("Это фигура {0}", item.Name + "<p>");
            }
            return str.ToString();
        }
        public string ExeTriCollection()
        {
            List<Triangle> tris = new List<Triangle>
            {
                new Triangle(6,7,9),
                new Triangle(7,8,10),
                new Triangle(8,9,11),
                new Triangle(9,10,12),
                new Triangle(10,11,13),
            };
            tris.Sort();
            StringBuilder str = new StringBuilder();
            foreach (Shape item in tris)
            {
                str.AppendFormat("Это {0}", item.Name + "<p>");
            }
            return str.ToString();
        }
    }
}