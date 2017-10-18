using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EasleyCollegeMiniProject.Models;

namespace EasleyCollegeMiniProject.Controllers
{
    public class Course_Student_JoinController : Controller
    {
        private EasleyCollegeMiniProjectContext db = new EasleyCollegeMiniProjectContext();

        // GET: Course_Student_Join
        public ActionResult Index()
        {
            var course_Student_Join = db.Course_Student_Join.Include(c => c.Course).Include(c => c.Student);
            return View(course_Student_Join.ToList());
        }

        // GET: Course_Student_Join/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course_Student_Join course_Student_Join = db.Course_Student_Join.Find(id);
            if (course_Student_Join == null)
            {
                return HttpNotFound();
            }
            return View(course_Student_Join);
        }

        // GET: Course_Student_Join/Create
        public ActionResult Create()
        {
            ViewBag.CourseID = new SelectList(db.Courses, "ID", "Title");
            ViewBag.StudentID = new SelectList(db.Students, "ID", "Name");
            return View();
        }

        // POST: Course_Student_Join/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,StudentID,CourseID")] Course_Student_Join course_Student_Join)
        {
            if (ModelState.IsValid)
            {
                db.Course_Student_Join.Add(course_Student_Join);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CourseID = new SelectList(db.Courses, "ID", "Title", course_Student_Join.CourseID);
            ViewBag.StudentID = new SelectList(db.Students, "ID", "Name", course_Student_Join.StudentID);
            return View(course_Student_Join);
        }

        // GET: Course_Student_Join/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course_Student_Join course_Student_Join = db.Course_Student_Join.Find(id);
            if (course_Student_Join == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseID = new SelectList(db.Courses, "ID", "Title", course_Student_Join.CourseID);
            ViewBag.StudentID = new SelectList(db.Students, "ID", "Name", course_Student_Join.StudentID);
            return View(course_Student_Join);
        }

        // POST: Course_Student_Join/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,StudentID,CourseID")] Course_Student_Join course_Student_Join)
        {
            if (ModelState.IsValid)
            {
                db.Entry(course_Student_Join).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseID = new SelectList(db.Courses, "ID", "Title", course_Student_Join.CourseID);
            ViewBag.StudentID = new SelectList(db.Students, "ID", "Name", course_Student_Join.StudentID);
            return View(course_Student_Join);
        }

        // GET: Course_Student_Join/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course_Student_Join course_Student_Join = db.Course_Student_Join.Find(id);
            if (course_Student_Join == null)
            {
                return HttpNotFound();
            }
            return View(course_Student_Join);
        }

        // POST: Course_Student_Join/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Course_Student_Join course_Student_Join = db.Course_Student_Join.Find(id);
            db.Course_Student_Join.Remove(course_Student_Join);
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
