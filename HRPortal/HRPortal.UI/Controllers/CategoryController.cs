using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.HtmlControls;
using HRPortal.Data;
using HRPortal.Models;
using HRPortal.UI.Models;

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

        
        public ActionResult CreateCategory()
        {
      
            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(Category newCategory)
        {
            if (ModelState.IsValid)
            {
                var categoryVM = new MockPolicyRepo();
                categoryVM.AddCategory(newCategory);
                return RedirectToAction("Index");
            }

            return View();
        }

        //TODO: add edit for category
        //TODO: add delete for category
        //TODO: add rederct to policy list for an individual category?? idk if it gos on this page
        //TODO: add policy

    }
}