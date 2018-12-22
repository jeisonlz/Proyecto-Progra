using ProyectoPr5.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PoryectoPr5.UI.Controllers
{
    public class HomeCustodiaController : Controller
    {
        // GET: HomeCustodia
        public ActionResult Index()
        {
            return View();

        }

        public ActionResult addArtCustodia() {
            return View();
        }
    }
}