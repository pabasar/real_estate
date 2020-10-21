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
            return View();
        }

        [HttpPost]
        public ActionResult Create(Rent rent)
        {
            if (ModelState.IsValid)
            {
                businessContext.Rents.Add(rent);
                businessContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}