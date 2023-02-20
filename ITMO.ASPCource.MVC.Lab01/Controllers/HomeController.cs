using ITMO.ASPCource.MVC.Lab01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITMO.ASPCource.MVC.Lab01.Controllers
{
    public class MyController : Controller
    {
        // GET: Home
        public string Index(string hel)
        {
            //int hour = DateTime.Now.Hour;
            //string Greeting = hour < 12 ? "Доюрое утро" : "Добрый день" + "," + hel;

            string Greeting = ModelClass.ModelHello() + ", " + hel;
            return Greeting;
        }
    }
}