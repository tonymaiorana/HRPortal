using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRPortal.Data;
using HRPortal.Models;
using HRPortal.UI.Models;

namespace HRPortal.UI.Controllers
{
    public class ResumeController : Controller
    {
        // GET: Resume
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateResume()
        {
            Resume r = new Resume()
            {
                Applicant = new Person { Address = new Address() },
                ApplyingPosition = new Position(),
                JobExperience = new JobExperience(),
                ResumeFile = new object(),
            };

            return View(new ResumeVM(new MockPositionRepository().GetAllPositions())
            {
                newResume = r
            });
        }

        [HttpPost]
        public ActionResult CreateResume(Resume newResume)
        {
            return View("Index");
        }
    }
}