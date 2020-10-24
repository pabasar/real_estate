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

        public ActionResult Edit(String id)
        {
            ViewBag.BranchDetails = new SelectList(businessContext.Branches, "BranchNo", "BranchNo", "BranchRef");
            Staff staff = businessContext.Staffs.SingleOrDefault(x => x.StaffNo == id);
            return View(staff);
        }

        [HttpPost]
        public ActionResult Edit(String id, Staff updatedStaff)
        {
            Staff staff = businessContext.Staffs.SingleOrDefault(x => x.StaffNo == id);
            staff.StaffNo = updatedStaff.StaffNo;
            staff.FName = updatedStaff.FName;
            staff.LName = updatedStaff.LName;
            staff.Position = updatedStaff.Position;
            staff.DOB = updatedStaff.DOB;
            staff.Salary = updatedStaff.Salary;
            staff.BranchRef = updatedStaff.BranchRef;
            businessContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(String id)
        {
            Staff staff = businessContext.Staffs.SingleOrDefault(x => x.StaffNo == id);
            return View(staff);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteStaff(String id)
        {
            Staff staff = businessContext.Staffs.SingleOrDefault(x => x.StaffNo == id);
            businessContext.Staffs.Remove(staff);
            businessContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}