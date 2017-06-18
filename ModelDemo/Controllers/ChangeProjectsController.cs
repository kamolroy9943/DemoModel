using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ModelDemo.DbContext;
using ModelDemo.Models;

namespace ModelDemo.Controllers
{
    public class ChangeProjectsController : Controller
    {
        private DemoModelDbContext db = new DemoModelDbContext();

        // GET: ChangeProjects
        public ActionResult Index()
        {
            return View(db.ChangeProjects.ToList());
        }

        // GET: ChangeProjects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChangeProject changeProject = db.ChangeProjects.Find(id);
            if (changeProject == null)
            {
                return HttpNotFound();
            }
            return View(changeProject);
        }

        // GET: ChangeProjects/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChangeProjects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProjectId,ProjectName,Date,ChangeRequestor,ChangeNo,RequestedChange,ChangeReason,AlternativeConsideration,TechnicalChanges,RiskConsiderationn,ReasourceCost,ImplementationQuality,Justification")] ChangeProject changeProject)
        {
            if (ModelState.IsValid)
            {
                db.ChangeProjects.Add(changeProject);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(changeProject);
        }

        // GET: ChangeProjects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChangeProject changeProject = db.ChangeProjects.Find(id);
            if (changeProject == null)
            {
                return HttpNotFound();
            }
            return View(changeProject);
        }

        // POST: ChangeProjects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProjectId,ProjectName,Date,ChangeRequestor,ChangeNo,RequestedChange,ChangeReason,AlternativeConsideration,TechnicalChanges,RiskConsiderationn,ReasourceCost,ImplementationQuality,Justification")] ChangeProject changeProject)
        {
            if (ModelState.IsValid)
            {
                db.Entry(changeProject).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(changeProject);
        }

        // GET: ChangeProjects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChangeProject changeProject = db.ChangeProjects.Find(id);
            if (changeProject == null)
            {
                return HttpNotFound();
            }
            return View(changeProject);
        }

        // POST: ChangeProjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChangeProject changeProject = db.ChangeProjects.Find(id);
            db.ChangeProjects.Remove(changeProject);
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
