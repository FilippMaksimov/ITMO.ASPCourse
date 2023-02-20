using ITMO.ASPCourse.MVC.Lab02.Ex03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITMO.ASPCourse.MVC.Lab02.Ex03.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            //string res = ExeTriangle();
            string res = ExeCircle();
            return res;
        }
        public string ExeTriangle()
        {
            Triangle tr1 = new Triangle(3, 5, 6);
            string sq1 = String.Format("Площадь фигуры {0} равна: {1:0.##}", tr1.Name, tr1.Area);
            return sq1;
        }
        public string ExeCircle()
        {
            Circle cir1 = new Circle(3);
            string sq = String.Format("Площадь фигуры {0} равна: {1:0.##}", cir1.Name, cir1.Area);
            return sq;
        }
    }
}