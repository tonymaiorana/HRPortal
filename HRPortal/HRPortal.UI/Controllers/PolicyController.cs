using HRPortal.Data;
using HRPortal.Models;
using HRPortal.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRPortal.UI.Controllers
{
    public class PolicyController : Controller
    {
        // GET: Policy
        public ActionResult Index()
        {
            var repo = new MockPolicyRepo();
            return View(repo.GetAllPolicies());
        }

        public ActionResult CreatePolicy()
        {
            return View(new PolicyVM(new MockPolicyRepo().GetAllCategories()) { Policy = new Policy() });
        }

        [HttpPost]
        public ActionResult CreatePolicy(Policy policy)
        {
            var repo = new MockPolicyRepo();
            policy.Category = repo.GetCategoryByID(policy.CategoryID);
            repo.AddPolicy(policy);
            return View("Index", repo.GetAllPolicies());
        }

        public ActionResult EditPolicy(int id)
        {
            Policy policy = new MockPolicyRepo().GetPolicyByID(id);
            return View(new PolicyVM(new MockPolicyRepo().GetAllCategories()) { Policy = policy });
        }

        [HttpPost]
        public ActionResult EditPolicyPost(Policy policy)
        {
            var repo = new MockPolicyRepo();
            policy.Category = repo.GetCategoryByID(policy.CategoryID);
            repo.EditPolicy(policy);
            return View("Index", repo.GetAllPolicies());
        }

        public ActionResult ManagePolicies()
        {
            var repo = new MockPolicyRepo();
            return View(repo.GetAllPolicies());
        }

        public ActionResult DeletePolicy(int id)
        {
            Policy policy = new MockPolicyRepo().GetPolicyByID(id);
            var repo = new MockPolicyRepo();
            repo.DeletePolicy(policy);
            return View("Index", repo.GetAllPolicies());
        }
    }
}