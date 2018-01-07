using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstBlog.Models;

namespace FirstBlog.Controllers
{
    public class HomeController : Controller
    {
        BlogDB _db = new BlogDB();
        public ActionResult Index()
        {
            var journals = _db.Journals.ToList();

            //var query = from j in _db.Journals
            //            where j.Caption == ""
            //            select j;


            
            return View(journals);
        }


    }
}