using ITMO.ASPCourse.MVC.ExamTask.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ITMO.ASPCourse.MVC.ExamTask.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        SchoolDataEntities1 db = new SchoolDataEntities1();

        [HttpGet]
        public ActionResult ViewStatistic()
        {
            var allStudents = db.Students.ToList();
            ViewBag.Students = allStudents;


            var sourceMain = db.Scores.ToList();
            DateTime maxDate = sourceMain.Max(x => x.ScoreDate).Value;
            var source = db.Scores.Where(x => x.ScoreDate.Value == maxDate).ToList();
            //Total Scores
            var items = source
                .GroupBy(a => a.StudentID, (key, item) => new TotalScoreData
                {
                    StudentID = key,
                    TotalScore = (int)item.Sum(a => a.ScoreResult)
                }).ToList();
            var model = new GroupedScoreData
            {
                Items = items,
                Total = (int)source.Sum(a => a.ScoreResult)
            };

            return View(model);
        }
        [ChildActionOnly]
        public PartialViewResult ViewStatistic1()
        {
            //Tot 5 Worst
            var sourceMain = db.Scores.ToList();
            DateTime maxDate = sourceMain.Max(x => x.ScoreDate).Value;
            var source = db.Scores.Where(x => x.ScoreDate.Value == maxDate).ToList();
            var worstItem = source
                .GroupBy(a => a.StudentID, (key, item) => new TotalScoreData
                {
                    StudentID = key,
                    TotalScore = (int)item.Sum(a => a.ScoreResult)
                }).OrderBy(a => a.TotalScore).Take(5).ToList();
            var modelBest = new GroupedScoreData
            {
                Items = worstItem,
                Total = (int)worstItem.Sum(a => a.TotalScore)
            };
            return PartialView(modelBest);
        }
        [ChildActionOnly]
        public PartialViewResult ViewStatistic2()
        {
            //Top 5 Best
            var sourceMain = db.Scores.ToList();
            DateTime maxDate = sourceMain.Max(x => x.ScoreDate).Value;
            var source = db.Scores.Where(x => x.ScoreDate.Value == maxDate).ToList();
            var bestItem = source
                .GroupBy(a => a.StudentID, (key, item) => new TotalScoreData
                {
                    StudentID = key,
                    TotalScore = (int)item.Sum(a => a.ScoreResult)
                }).OrderByDescending(a => a.TotalScore).Take(5).ToList();
            var modelWorst = new GroupedScoreData
            {
                Items = bestItem,
                Total = (int)bestItem.Sum(a => a.TotalScore)
            };
            return PartialView(modelWorst);
        }
    }
}