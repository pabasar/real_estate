using RealEstateBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstateBusiness.Controllers
{
    public class HomeController : Controller
    {
        private BusinessContext businessContext = new BusinessContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Branch()
        {
            List<Branch> branches = businessContext.Branches.ToList();
            return View(branches);
        }

        public ActionResult StaffInBranch(String BranchNo)
        {
            List<Staff> staffs = businessContext.Staffs.Where(x => x.BranchRef == BranchNo).ToList();
            return View(staffs);
        }

        public ActionResult RentInBranch(String BranchNo)
        {
            List<Rent> rents = businessContext.Rents.Where(x => x.BranchRef == BranchNo).ToList();
            return View(rents);
        }

        public ActionResult Rent()
        {
            List<Rent> rents = businessContext.Rents.ToList();
            return View(rents);
        }


        public ActionResult Position()
        {
            List<Staff> staffs = businessContext.Staffs.ToList();
            return View(staffs);
        }

        public ActionResult StaffInPosition(String pos)
        {
            List<Staff> staffs = businessContext.Staffs.Where(x => x.Position == pos).ToList();
            return View(staffs);
        }

        public ActionResult City()
        {
            List<Rent> rents = businessContext.Rents.ToList();
            return View(rents);
        }

        public ActionResult RentInCity(String city)
        {
            List<Rent> rents = businessContext.Rents.Where(x => x.City == city).ToList();
            return View(rents);
        }
    }
}