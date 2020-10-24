using RealEstateBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstateBusiness.Controllers
{
    public class BranchController : Controller
    {
        private BusinessContext businessContext = new BusinessContext();
        // GET: Branch
        public ActionResult Index()
        {
            List<Branch> BranchList = businessContext.Branches.ToList();
            return View(BranchList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Branch branch)
        {
            if (ModelState.IsValid)
            {
                businessContext.Branches.Add(branch);
                businessContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Details(String id)
        {
            Branch branch = businessContext.Branches.SingleOrDefault(x => x.BranchNo == id);
            return View(branch);
        }

        public ActionResult Edit(String id)
        {
            Branch branch = businessContext.Branches.SingleOrDefault(x => x.BranchNo == id);
            return View(branch);
        }

        [HttpPost]
        public ActionResult Edit()
        {
            return View();
        }
    }
}