using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProyectoPr5.DAL;

namespace PoryectoPr5.UI.Controllers
{
    public class artEntregadosController : Controller
    {
        private ProyectoPR5Entities db = new ProyectoPR5Entities();

        // GET: artEntregados
        public ActionResult Index()
        {
            var artEntregados = db.artEntregados.Include(a => a.Categoria);
            return View(artEntregados.ToList());
        }

        // GET: artEntregados/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            artEntregados artEntregados = db.artEntregados.Find(id);
            if (artEntregados == null)
            {
                return HttpNotFound();
            }
            return View(artEntregados);
        }

        // GET: artEntregados/Create
        public ActionResult Create()
        {
            ViewBag.idCategoria = new SelectList(db.Categoria, "idCategoria", "nombreCategoria");
            return View();
        }

        // POST: artEntregados/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idArticuloEnt,nombre,idCategoria,FechaIngreso,descripcion")] artEntregados artEntregados)
        {
            if (ModelState.IsValid)
            {
                db.artEntregados.Add(artEntregados);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idCategoria = new SelectList(db.Categoria, "idCategoria", "nombreCategoria", artEntregados.idCategoria);
            return View(artEntregados);
        }

        // GET: artEntregados/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            artEntregados artEntregados = db.artEntregados.Find(id);
            if (artEntregados == null)
            {
                return HttpNotFound();
            }
            ViewBag.idCategoria = new SelectList(db.Categoria, "idCategoria", "nombreCategoria", artEntregados.idCategoria);
            return View(artEntregados);
        }

        // POST: artEntregados/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idArticuloEnt,nombre,idCategoria,FechaIngreso,descripcion")] artEntregados artEntregados)
        {
            if (ModelState.IsValid)
            {
                db.Entry(artEntregados).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idCategoria = new SelectList(db.Categoria, "idCategoria", "nombreCategoria", artEntregados.idCategoria);
            return View(artEntregados);
        }

        // GET: artEntregados/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            artEntregados artEntregados = db.artEntregados.Find(id);
            if (artEntregados == null)
            {
                return HttpNotFound();
            }
            return View(artEntregados);
        }

        // POST: artEntregados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            artEntregados artEntregados = db.artEntregados.Find(id);
            db.artEntregados.Remove(artEntregados);
            db.SaveChanges();
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
