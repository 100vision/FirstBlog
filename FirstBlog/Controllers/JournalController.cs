using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstBlog.Models;

namespace FirstBlog.Controllers
{
    public class JournalController : Controller
    {
        // GET: Journal
        BlogDB _db = new BlogDB();

        public ActionResult Index()
        {
            var query = from j in _db.Journals
                        orderby j.Date descending
                        select j;
            return View(query);
        }

        [HttpPost]
        public  ActionResult Add(Journal journal)
        {

            _db.Journals.Add(journal);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Add()
        {
            return View();
        }

        public  ActionResult Edit(int ID)
        {
            var journal = Queryable.Single(_db.Journals,a=>a.Id==ID);
            return View(journal);
        }

        [HttpPost]
        public ActionResult Edit(Journal journal)
        {
            _db.Entry(journal).State = System.Data.Entity.EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}