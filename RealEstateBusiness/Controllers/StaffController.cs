using RealEstateBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstateBusiness.Controllers
{
    public class StaffController : Controller
    {
        private BusinessContext businessContext = new BusinessContext();
        // GET: Staff
        public ActionResult Index()
        {
            List<Staff> StaffList = businessContext.Staffs.ToList();
            return View(StaffList);
        }

        public ActionResult Create()
        {
            ViewBag.BranchDetails = businessContext.Branches;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Staff staff)
        {
            if (ModelState.IsValid)
            {
                ViewBag.BranchDetails = businessContext.Branches;
                businessContext.Staffs.Add(staff);
                businessContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Details(String id)
        {
            Staff staff = businessContext.Staffs.SingleOrDefault(x => x.StaffNo == id);
            return View(staff);
        }
    }
}