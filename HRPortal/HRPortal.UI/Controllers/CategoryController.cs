using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRPortal.Data;
using HRPortal.Models;

namespace HRPortal.UI.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            var repo = new MockPolicyRepo();
            return View(repo.GetAllCategories());
        }

        ////TODO: Need help with what to return in the view
        //public ActionResult CreateCategory()
        //{
        //    Category c = new Category()
        //    {
        //        //TODO:need help with id incroment
        //        CategoryID = new int(),
        //        CategoryTitle = new string()
        //    };
        //    return View(new categoryVM(new MockPolicyRepo().GetAllCategories())
        //    {
        //        newCategory = c
        //    });
        //}

        //[HttpPost]
        //public ActionResult CreateCategory(Category newCategory)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var categoryVM = new MockPolicyRepo();
        //        categoryVM.AddCategory(newCategory);
        //        return RedirectToAction("Index");
        //    }
           
        //    return View();
        //}

        //TODO: add edit for category
        //TODO: add delete for category
        //TODO: add rederct to policy list for an individual category?? idk if it gos on this page


    }
}