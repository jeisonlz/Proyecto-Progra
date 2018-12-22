using ProyectoPr5.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PoryectoPr5.UI.Controllers
{
    public class HomeController : Controller
    {
        public ProyectoPr5.DAL.ProyectoPR5Entities db = new ProyectoPr5.DAL.ProyectoPR5Entities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult asignarRoles()
        {
           
            var Usuario = db.Usuarios.ToList();

            return View(Usuario);
        }




        public ActionResult EditarRoles(int? id)
        {
            var r = new Models.InfoUsuarios();

            return View (r.DatosbyID(id));
        }


        public ActionResult IndexUpdateCategoria()
        {
            return View();
        }

        public ActionResult IndexAddCategoria()
        {
            return View();
        }

    }
}