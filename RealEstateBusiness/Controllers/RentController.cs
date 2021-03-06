﻿using RealEstateBusiness.Models;
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

        public ActionResult Edit(String id)
        {
            ViewBag.BranchDetails = new SelectList(businessContext.Branches, "BranchNo", "BranchNo", "BranchRef");
            ViewBag.StaffDetails = new SelectList(businessContext.Staffs, "StaffNo", "FName", "StaffNo");
            ViewBag.OwnerDetails = new SelectList(businessContext.Owners, "OwnerNo", "FName", "OwnerNo");
            Rent rent = businessContext.Rents.SingleOrDefault(x => x.PropertyNo == id);
            return View(rent);
        }

        [HttpPost]
        public ActionResult Edit(String id, Rent updatedRent)
        {
            Rent rent = businessContext.Rents.SingleOrDefault(x => x.PropertyNo == id);
            rent.PropertyNo = updatedRent.PropertyNo;
            rent.Street = updatedRent.Street;
            rent.City = updatedRent.City;
            rent.PType = updatedRent.PType;
            rent.Rooms = updatedRent.Rooms;
            rent.OwnerRef = updatedRent.OwnerRef;
            rent.StaffRef = updatedRent.StaffRef;
            rent.BranchRef = updatedRent.BranchRef;
            rent.Rent1 = updatedRent.Rent1;
            businessContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(String id)
        {
            Rent rent = businessContext.Rents.SingleOrDefault(x => x.PropertyNo == id);
            return View(rent);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteRent(String id)
        {
            Rent rent = businessContext.Rents.SingleOrDefault(x => x.PropertyNo == id);
            businessContext.Rents.Remove(rent);
            businessContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}