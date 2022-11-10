using librarynew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace librarynew.Controllers
{
    public class IssueBookController : Controller
    {
        nitlibraryEntities1 db = new nitlibraryEntities1();
        // GET: IssueBook
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Getbook()
        {
            var books = db.books.Select(p => new
            {
                ID = p.Id,
                Bname = p.bname
            }).ToList();
            return Json(books, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult GetMid(int mid)
        {
            var memberid = (from s in db.members where s.Id == mid select s.name).ToList();
            return Json(memberid, JsonRequestBehavior.AllowGet);
         }

        [HttpPost]
        public ActionResult Save(issuebook issue)
        {
            if (ModelState.IsValid) 
            {
                db.issuebooks.Add(issue);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(issue);
        }
    }
}