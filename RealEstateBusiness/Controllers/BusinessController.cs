using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstateBusiness.Controllers
{
    public class BusinessController : Controller
    {
        // GET: Business
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateBranch()
        {
            return View();
        }

        public ActionResult CreateOwner()
        {
            return View();
        }

        public ActionResult CreateStaff()
        {
            return View();
        }

        public ActionResult CreateRent()
        {
            return View();
        }
    }
}