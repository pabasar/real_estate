using RealEstateBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstateBusiness.Controllers
{
    public class RentController : Controller
    {
        private BusinessContext businessContext = new BusinessContext();
        // GET: Rent
        public ActionResult Index()
        {
            List<Rent> RentList = businessContext.Rents.ToList();
            return View(RentList);
        }

        public ActionResult Create()
        {
            ViewBag.BranchDetails = businessContext.Branches;
            ViewBag.StaffDetails = businessContext.Staffs;
            ViewBag.OwnerDetails = businessContext.Owners;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Rent rent)
        {
            if (ModelState.IsValid)
            {
                ViewBag.BranchDetails = businessContext.Branches;
                ViewBag.StaffDetails = businessContext.Staffs;
                ViewBag.OwnerDetails = businessContext.Owners;
                businessContext.Rents.Add(rent);
                businessContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Details(String id)
        {
            Rent rent = businessContext.Rents.SingleOrDefault(x => x.PropertyNo == id);
            return View(rent);
        }
    }
}