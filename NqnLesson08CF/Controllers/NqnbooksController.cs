using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NqnLesson08CF.Models;

namespace NqnLesson08CF.Controllers
{
    public class NqnbooksController : Controller
    {
        private NqnBookStore db = new NqnBookStore();

        // GET: Nqnbooks
        public ActionResult NqnIndex()
        {
            return View(db.NqnBooks.ToList());
        }

        // GET: Nqnbooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nqnbook nqnbook = db.NqnBooks.Find(id);
            if (nqnbook == null)
            {
                return HttpNotFound();
            }
            return View(nqnbook);
        }

        // GET: Nqnbooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Nqnbooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NqnbookId,NqnTitle,NqnAuthor,NqnYear,NqnPicture,NqnCategoryId")] Nqnbook nqnbook)
        {
            if (ModelState.IsValid)
            {
                db.NqnBooks.Add(nqnbook);
                db.SaveChanges();
                return RedirectToAction("NqnIndex");
            }

            return View(nqnbook);
        }

        // GET: Nqnbooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nqnbook nqnbook = db.NqnBooks.Find(id);
            if (nqnbook == null)
            {
                return HttpNotFound();
            }
            return View(nqnbook);
        }

        // POST: Nqnbooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NqnbookId,NqnTitle,NqnAuthor,NqnYear,NqnPicture,NqnCategoryId")] Nqnbook nqnbook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nqnbook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NqnIndex");
            }
            return View(nqnbook);
        }

        // GET: Nqnbooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nqnbook nqnbook = db.NqnBooks.Find(id);
            if (nqnbook == null)
            {
                return HttpNotFound();
            }
            return View(nqnbook);
        }

        // POST: Nqnbooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Nqnbook nqnbook = db.NqnBooks.Find(id);
            db.NqnBooks.Remove(nqnbook);
            db.SaveChanges();
            return RedirectToAction("NqnIndex");
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
