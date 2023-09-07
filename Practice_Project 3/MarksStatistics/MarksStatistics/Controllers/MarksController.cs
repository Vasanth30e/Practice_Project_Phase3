using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MarksStatistics.Models;

namespace MarksStatistics.Controllers
{
    public class MarksController : Controller
    {
        private Rainbow_SchoolDbEntities db = new Rainbow_SchoolDbEntities();

        // GET: Marks
        public ActionResult Index()
        {
            var marks = db.Marks.Include(m => m.Class).Include(m => m.Student).Include(m => m.Subject);
            return View(marks.ToList());
        }

        // GET: Marks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mark mark = db.Marks.Find(id);
            if (mark == null)
            {
                return HttpNotFound();
            }
            return View(mark);
        }

        // GET: Marks/Create
        public ActionResult Create()
        {
            ViewBag.ClassId = new SelectList(db.Classes, "ClassID", "ClassName");
            ViewBag.StudentId = new SelectList(db.Students, "StudentID", "FirstName");
            ViewBag.SubjectId = new SelectList(db.Subjects, "SubjectID", "SubjectName");
            return View();
        }

        // POST: Marks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MarkId,StudentId,ClassId,SubjectId,MarksObtained")] Mark mark)
        {
            if (ModelState.IsValid)
            {
                db.Marks.Add(mark);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ClassId = new SelectList(db.Classes, "ClassID", "ClassName", mark.ClassId);
            ViewBag.StudentId = new SelectList(db.Students, "StudentID", "FirstName", mark.StudentId);
            ViewBag.SubjectId = new SelectList(db.Subjects, "SubjectID", "SubjectName", mark.SubjectId);
            return View(mark);
        }

        // GET: Marks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mark mark = db.Marks.Find(id);
            if (mark == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClassId = new SelectList(db.Classes, "ClassID", "ClassName", mark.ClassId);
            ViewBag.StudentId = new SelectList(db.Students, "StudentID", "FirstName", mark.StudentId);
            ViewBag.SubjectId = new SelectList(db.Subjects, "SubjectID", "SubjectName", mark.SubjectId);
            return View(mark);
        }

        // POST: Marks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MarkId,StudentId,ClassId,SubjectId,MarksObtained")] Mark mark)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mark).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClassId = new SelectList(db.Classes, "ClassID", "ClassName", mark.ClassId);
            ViewBag.StudentId = new SelectList(db.Students, "StudentID", "FirstName", mark.StudentId);
            ViewBag.SubjectId = new SelectList(db.Subjects, "SubjectID", "SubjectName", mark.SubjectId);
            return View(mark);
        }

        // GET: Marks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mark mark = db.Marks.Find(id);
            if (mark == null)
            {
                return HttpNotFound();
            }
            return View(mark);
        }

        // POST: Marks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mark mark = db.Marks.Find(id);
            db.Marks.Remove(mark);
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
