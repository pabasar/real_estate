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

        public ActionResult Staffs()
        {
            List<Staff> Staffs = businessContext.Staffs.ToList();
            return View(Staffs);
        }

        public ActionResult Branches()
        {
            List<Branch> AllBranches = businessContext.Branches.ToList();
            return View(AllBranches);
        }

        public ActionResult StaffNames()
        {
            List<Staff> StaffName = businessContext.Staffs.ToList();
            return View(StaffName);
        }

        public ActionResult StaffDetails(String id)
        {
            Staff staff = businessContext.Staffs
                .SingleOrDefault(x => x.StaffNo == id);
            return View(staff);
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
            List<Branch> branches = businessContext.Branches.ToList();
            return View(branches);
        }

        public ActionResult StaffInPosition(String pos)
        {
            List<Staff> staffs = businessContext.Staffs.Where(x => x.Position == pos).ToList();
            return View(staffs);
        }
    }
}