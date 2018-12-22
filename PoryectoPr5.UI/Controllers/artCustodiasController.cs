using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PoryectoPr5.UI.ServiceWCF;
using ProyectoPr5.DAL;

namespace PoryectoPr5.UI.Controllers
{
    public class artCustodiasController : Controller
    {
        private ProyectoPR5Entities db = new ProyectoPR5Entities();

      
        public ActionResult Index()
        {
            var artCustodia = db.artCustodia.Include(a => a.Categoria);
            return View(artCustodia.ToList());
        }



        public ActionResult Index2()
        {
            var artCustodia = db.artCustodia.Include(a => a.Categoria);
            return View(artCustodia.ToList());
        }


        public ActionResult Create()
        {
            ViewBag.idCategoria = new SelectList(db.Categoria, "idCategoria", "nombreCategoria");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idArticuloCus,nombre,idCategoria,FechaIngreso,descripcion")] artCustodia artCustodia)
        {
            string pagina = "Create";
            if (ModelState.IsValid)
            {
              
               

                Service1Client service = new Service1Client();
                service.AgregarArt(artCustodia);
                service.Close();

                pagina = "Create";
                TempData["msg"] = "<script>alert('Articulo Ingresado');</script>";
                ModelState.Clear();

                
            }

            ViewBag.idCategoria = new SelectList(db.Categoria, "idCategoria", "nombreCategoria", artCustodia.idCategoria);
            return View(pagina);
        }

      

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            artCustodia artCustodia = db.artCustodia.Find(id);
            if (artCustodia == null)
            {
                return HttpNotFound();
            }
            return View(artCustodia);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            /* artCustodia artCustodia = db.artCustodia.Find(id);
             db.artCustodia.Remove(artCustodia);
             db.SaveChanges();*/
            var sss = new artCustodia();
            sss.idArticuloCus = id;

            Service1Client service = new Service1Client();
            service.EliminarArtCustodia(sss);
            service.Close();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
