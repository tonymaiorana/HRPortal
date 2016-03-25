﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRPortal.Data;

namespace HRPortal.UI.Controllers
{
    public class ResumeController : Controller
    {
        // GET: Resume
        public ActionResult Index()
        {
            var repo = new MockResumeRepository();
            return View(repo.GetAllResumes());
        }

        // GET: Resume/Details/5
        public ActionResult Details(int id)
        {
            var repo = new MockResumeRepository();
            return View(repo.GetByID(id));
        }

        // GET: Resume/Create
        public ActionResult Create()
        {
            //drop down shit
            //like the viewModles example
            return View();
        }

        // POST: Resume/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Resume/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Resume/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Resume/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Resume/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}