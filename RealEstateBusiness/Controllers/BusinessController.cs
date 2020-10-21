using RealEstateBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstateBusiness.Controllers
{
    public class BusinessController : Controller
    {
        private BusinessContext businessContext = new BusinessContext();
        // GET: Business
        public ActionResult Index()
        {
            return View();
        }

    }
}