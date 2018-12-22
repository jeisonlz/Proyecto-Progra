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
    public class CategoriasController : Controller
    {
        private ProyectoPR5Entities db = new ProyectoPR5Entities();

        
        public ActionResult Index()
        {
            return View(db.Categoria.ToList());
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCategoria,nombreCategoria")] Categoria categoria)
        {
            string pagina = "Create";
            if (ModelState.IsValid)
            {
            
                Categoria p = new Categoria();
                p.idCategoria = categoria.idCategoria;
                p.nombreCategoria = categoria.nombreCategoria;
               


                Service1Client service = new Service1Client();
                int ok=service.NuevaCategoria(p);
                service.Close();
                if (ok == 1)
                {
                    pagina = "Create";
                    TempData["msg"] = "<script>alert('Categoria Creada');</script>";
                }
                else
                {
                    TempData["msg"] = "<script>alert('Ya existe una categoria con este nombre');</script>";
                    pagina = "Create";
                }

               
            }
            
            return View(pagina);
        }


        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria categoria = db.Categoria.Find(id);
            if (categoria == null)
            {
                return HttpNotFound();
            }
            return View(categoria);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCategoria,nombreCategoria")] Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Service1Client service = new Service1Client();
                    int ok = service.CambiarCategoria(categoria);
                    service.Close();
                    return RedirectToAction("Index");
                }
                catch (Exception) {

                }
                }
            return View(categoria);
        }

      
    }
}
