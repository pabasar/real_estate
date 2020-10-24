using RealEstateBusiness.Models;
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

        public ActionResult Details(String id)
        {
            Owner owner = businessContext.Owners.SingleOrDefault(x => x.OwnerNo == id);
            return View(owner);
        }

        public ActionResult Edit(String id)
        {
            Owner owner = businessContext.Owners.SingleOrDefault(x => x.OwnerNo == id);
            return View(owner);
        }

        [HttpPost]
        public ActionResult Edit(String id, Owner updatedOwner)
        {
            Owner owner = businessContext.Owners.SingleOrDefault(x => x.OwnerNo == id);
            owner.OwnerNo = updatedOwner.OwnerNo;
            owner.FName = updatedOwner.FName;
            owner.LName = updatedOwner.LName;
            owner.Address = updatedOwner.Address;
            owner.TelNo = updatedOwner.TelNo;
            businessContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(String id)
        {
            Owner owner = businessContext.Owners.SingleOrDefault(x => x.OwnerNo == id);
            return View(owner);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteOwner(String id)
        {
            Owner owner = businessContext.Owners.SingleOrDefault(x => x.OwnerNo == id);
            businessContext.Owners.Remove(owner);
            businessContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}