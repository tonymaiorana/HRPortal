using HRPortal.Data;
using HRPortal.Models;
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
            return View();
        }

        [HttpPost]
        public ActionResult CreatePolicy(Policy policy)
        {
            return View();
        }

        public ActionResult EditPolicy()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditPolicy(Policy policy)
        {
            return View();
        }

        public ActionResult ManagePolicies()
        {
            return View();
        }
    }
}