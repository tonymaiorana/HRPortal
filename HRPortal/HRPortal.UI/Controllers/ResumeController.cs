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
    public class ResumeController : Controller
    {
        // GET: Resume
        public ActionResult Index()
        {
            var repo = new ResumeRepo();
            return View(repo.GetAllResumes());
        }

        public ActionResult CreateResume()
        {
            Resume r = new Resume()
            {
                Applicant = new Person { Address = new Address() },
                ApplyingPosition = new Position(),
                JobExperience = new List<JobExperience>() { new JobExperience() },
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
            if (Request.Form.AllKeys.Contains("MoreJobExperience"))
            {
                newResume.JobExperience.Add(new JobExperience());
                return View(new ResumeVM(new MockPositionRepository().GetAllPositions())
                {
                    newResume = newResume
                });
            }

            if (ModelState.IsValid)
            {
                var repo = new ResumeRepo();
                newResume.DateCreated = DateTime.Now;
                newResume.DateUpdated = DateTime.Now;
                repo.Add(newResume);
                return View("Success");
            }
            var vm = new ResumeVM(new MockPositionRepository().GetAllPositions())
            {
                newResume = newResume
            };
            return View(vm);
        }

        public ActionResult EditResume(int id)
        {
            return View(new ResumeVM(new MockPositionRepository().GetAllPositions())
            {
                newResume = new MockResumeRepository().GetByID(id)
            });
        }

        [HttpPost]
        public ActionResult EditResume(Resume newResume)
        {
            if (ModelState.IsValid)
            {
                var resumeVM = new MockResumeRepository();
                newResume.DateUpdated = DateTime.Now;
                resumeVM.Add(newResume);
                return RedirectToAction("Index");
            }
            var vm = new ResumeVM(new MockPositionRepository().GetAllPositions())
            {
                newResume = newResume
            };
            return View(vm);
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteResume(int id)
        {
            var resumeVM = new MockResumeRepository();
            resumeVM.Delete(id);
            return View("Index", resumeVM.GetAllResumes());
        }
    }
}