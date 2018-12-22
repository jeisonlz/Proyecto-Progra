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
    public class UsuariosController : Controller
    {
        private ProyectoPR5Entities db = new ProyectoPR5Entities();

       
        public ActionResult Index()
        {
            return View(db.Usuarios.ToList());
        }

     
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuarios usuarios = db.Usuarios.Find(id);
            if (usuarios == null)
            {
                return HttpNotFound();
            }
            return View(usuarios);
        }

   
        public ActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idUsuario,cedula,pass,idRol,nombre,telefono,correo")] Usuarios usuarios)
        {
            if (ModelState.IsValid)
            {
                Service1Client service = new Service1Client();
                int ok = service.registrarUsuarioNuevo(usuarios);
                service.Close();
            }
            ModelState.Clear();
            return View(usuarios);
        }

 
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuarios usuarios = db.Usuarios.Find(id);
            if (usuarios == null)
            {
                return HttpNotFound();
            }
            return View(usuarios);
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idUsuario,cedula,pass,idRol,nombre,telefono,correo")] Usuarios usuarios)
        {
            if (ModelState.IsValid)
            {
                Service1Client service = new Service1Client();
                int ok = service.CambiarRol(usuarios);
                service.Close();
                return RedirectToAction("Index");
                
            }
            return View(usuarios);
        }

        
    }
}
