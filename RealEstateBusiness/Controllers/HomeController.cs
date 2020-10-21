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
        private BusinessContext campusContext = new BusinessContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}