using MVCNorthwind_0.DesignPatterns.SingletonPattern;
using MVCNorthwind_0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCNorthwind_0.Controllers
{
    public class CategoryController : Controller
    {

        NorthwindEntities _db;

        public CategoryController()
        {
            _db = DBTool.DBInstance;
        }


        public ActionResult BringCategories()
        {
            return View(_db.Categories.ToList());
        }

        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category item)
        {
            _db.Categories.Add(item);
            _db.SaveChanges();
            return RedirectToAction("BringCategories");
        }
    }
}