using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITMO.ASPCourse.MVC.Lab03.Lab04.Lab05.Lab06.Lab08.Models;

namespace ITMO.ASPCourse.MVC.Lab03.Lab04.Lab05.Lab06.Lab08.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Доброе утро" : "Добрый день";
            ViewData["Mes"] = "хорошего настроения";
            return View();
        }
        private static PersonRepository db = new PersonRepository();

        [HttpGet]
        public ViewResult InputData()
        {
            return View();
        }
        [HttpPost]
        public ViewResult InputData(Person p)
        {
            db.AddRespose(p);
            return View("Hello", p);
        }
        public ViewResult OutputData()
        {
            ViewBag.Pers = db.GettAllResposes;
            ViewBag.Count = db.NumberOfPerson;
            return View("ListPerson");
        }
    }
}