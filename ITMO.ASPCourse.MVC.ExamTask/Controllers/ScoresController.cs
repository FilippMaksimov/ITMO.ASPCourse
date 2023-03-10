using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ITMO.ASPCourse.MVC.ExamTask.Models;

namespace ITMO.ASPCourse.MVC.ExamTask.Controllers
{
    public class ScoresController : Controller
    {
        private SchoolDataEntities1 db = new SchoolDataEntities1();

        public ActionResult Index()
        {
            var scores = db.Scores.Include(s => s.Student);
            return View(scores.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Score score = db.Scores.Find(id);
            if (score == null)
            {
                return HttpNotFound();
            }
            return View(score);
        }
        public void GetList()
        {
            var list = new List<string>() { "Math", "Biology", "English", "Physics", "Chemistry", "Geography", "History", "Info Technologies" };
            ViewBag.list = list;
            ViewBag.StudentID = new SelectList(db.Students, "ID", "StudentName");
        }

        public ActionResult Create()
        {
            GetList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ScoreID,StudentID,SubjectName,ScoreResult,ScoreDate")] Score score)
        {
            if (ModelState.IsValid)
            {
                db.Scores.Add(score);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StudentID = new SelectList(db.Students, "ID", "StudentName", score.StudentID);
            return View(score);
        }

        public ActionResult Edit(int? id)
        {
            GetList();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Score score = db.Scores.Find(id);
            if (score == null)
            {
                return HttpNotFound();
            }
            ViewBag.StudentID = new SelectList(db.Students, "ID", "StudentName", score.StudentID);
            return View(score);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ScoreID,StudentID,SubjectName,ScoreResult,ScoreDate")] Score score)
        {
            GetList();
            if (ModelState.IsValid)
            {
                db.Entry(score).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StudentID = new SelectList(db.Students, "ID", "StudentName", score.StudentID);
            return View(score);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Score score = db.Scores.Find(id);
            if (score == null)
            {
                return HttpNotFound();
            }
            return View(score);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Score score = db.Scores.Find(id);
            db.Scores.Remove(score);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
