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

        public ActionResult DeleteCategory(int id)
        {
            var categoryVM = new MockPolicyRepo();
            var cat = categoryVM.GetCategoryByID(id);
            return View(cat);
        }

        [HttpPost]

        public ActionResult DeleteCategory(Category category)
        {
           
                var categoryVM = new MockPolicyRepo();
                categoryVM.DeleteCategory(category);
                return RedirectToAction("Index");
            
        }

        public ActionResult EditCategory(int id)
        {
            var categoryVM = new MockPolicyRepo();
            var cat = categoryVM.GetCategoryByID(id);
            return View(cat);
        }

        [HttpPost]
        public ActionResult EditCategory(Category category)
        {
           
                var categoryVM = new MockPolicyRepo();
                categoryVM.EditCategory(category);
                return RedirectToAction("Index");
            
        }
        //TODO: add delete for category
        //TODO: add rederct to policy list for an individual category?? idk if it gos on this page
        //TODO: add policy

    }
}