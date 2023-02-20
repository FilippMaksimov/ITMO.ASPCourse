using ITMO.ASPCourse.MVC.Lab02.Ex02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITMO.ASPCourse.MVC.Lab02.Ex02.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index(string hel)
        {
            //string res = StudyCsharp.SetStatus(3);
            //string res = StudyCsharp.ExeSwitch(StudyCsharp.SetStatus(3));

            //string res = StudyCsharp.GetFunction(0, 9);
            string res = ExeFactorial(5);
            return res;
        }
        public string ExeFactorial (int x)
        {
            int f;
            bool ok = StudyCsharp.Factorial(x, out f);
            if (ok)
            {
                return String.Format("Факториал числа {0} равен {1}", x, f);
            }
            else
            {
                return "Невозможно вычислить факториал";
            }
        }
    }
}