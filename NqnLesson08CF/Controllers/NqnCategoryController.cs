using NqnLesson08CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NqnLesson08CF.Controllers
{
    public class NqnCategoryController : Controller
    {
        private static NqnBookStore _NqnbookStore;
        public NqnCategoryController() 
        {
            _NqnbookStore = new NqnBookStore();
        }
        // GET: NqnCategory
        public ActionResult NqnIndex()
        {
            var nqnCategory = _NqnbookStore.NqnCategories.ToList();
            return View(nqnCategory);
        }
        [HttpGet]
        public ActionResult NqnCreate()
        {
            var nqnCategory = new NqnCategory();
            return View(nqnCategory);
        }
        [HttpPost]
        public ActionResult NqnCreate(NqnCategory nqnCategory)
        {
            _NqnbookStore.NqnCategories.Add(nqnCategory);
            _NqnbookStore.SaveChanges();
            return View(nqnCategory);
        }
    }
}