﻿using RealEstateBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstateBusiness.Controllers
{
    public class OwnerController : Controller
    {
        private BusinessContext businessContext = new BusinessContext();
        // GET: Owner
        public ActionResult Index()
        {
            List<Owner> OwnerList = businessContext.Owners.ToList();
            return View(OwnerList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Owner owner)
        {
            if (ModelState.IsValid)
            {
                businessContext.Owners.Add(owner);
                businessContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}