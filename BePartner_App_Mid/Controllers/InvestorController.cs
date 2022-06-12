using BePartner_App_Mid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BePartner_App_Mid.Controllers
{
    public class InvestorController : Controller
    {
        // GET: Investor
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(Investor In)
        {
            return View(In);
        }

        [HttpGet]
        public ActionResult Registration2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration2(Investor In2)
        {
            return View(In2);
        }
    }
}