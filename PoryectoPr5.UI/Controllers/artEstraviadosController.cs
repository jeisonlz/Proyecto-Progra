using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using PoryectoPr5.UI.ServiceWCF;
using ProyectoPr5.DAL;

namespace PoryectoPr5.UI.Controllers
{
    public class artEstraviadosController : Controller
    {
        private ProyectoPR5Entities db = new ProyectoPR5Entities();

        // GET: artEstraviados
        public ActionResult Index()
        {
            var artEstraviados = db.artEstraviados.Include(a => a.Categoria);
            return View(artEstraviados.ToList());
        }

        public ActionResult Index2()
        {
            var artEstraviados = db.artEstraviados.Include(a => a.Categoria);
            return View(artEstraviados.ToList());
        }


        public ActionResult notificarUsuarios()
        {
            return View();
        }

        [HttpPost]
        public ActionResult enviarMail(Models.ContactarModel nuevo)
        {

            MailMessage mmsg = new MailMessage();

            var r = ProyectoPr5.BL.Clases.ManUsuarioss._Instancia.Mostrar();

            var correosx = (from a in r
                            select new { a.correo }).ToList();
            try { 
            bool ok = false;
            string toCorreo;
            foreach (var ele in correosx)
            {
                toCorreo = ele.correo;
                if (toCorreo != null)
                {
                    mmsg.To.Add(toCorreo);
                    mmsg.Subject = ("Articulo Nuevo Ingresado");
                    mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
                    mmsg.Body = nuevo.mensaje;
                    mmsg.BodyEncoding = System.Text.Encoding.UTF8;
                    mmsg.IsBodyHtml = true;
                    mmsg.From = new System.Net.Mail.MailAddress("proyectopr52018@gmail.com");

                    SmtpClient cliente = new SmtpClient();
                    cliente.Credentials = new NetworkCredential("proyectopr52018@gmail.com", "hola123@");
                    cliente.Port = 587;
                    cliente.EnableSsl = true;
                    cliente.Host = "smtp.gmail.com";

                    try
                    {
                        cliente.Send(mmsg);
                        ok = true;
                    }
                    catch (Exception)
                    {


                    }
                }

           

        }

            if (ok)
            {
                TempData["msg"] = "<script>alert('Correos Enviados Satisfactoriamente');</script>";
            }
        }catch (Exception) {
            }
                ModelState.Clear();
            return View("notificarUsuarios");

        }



        // GET: artEstraviados/Create
        public ActionResult Create()
        {
            ViewBag.idCategoria = new SelectList(db.Categoria, "idCategoria", "nombreCategoria");
            return View();
        }

        // POST: artEstraviados/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idArticuloExt,nombre,idCategoria,FechaIngreso,descripcion,IngresadoPor,Telefono_Contacto")] artEstraviados artEstraviados)
        {
            if (ModelState.IsValid)
            {
                /*  db.artEstraviados.Add(artEstraviados);
                  db.SaveChanges();
                  return RedirectToAction("Index");*/

                Service1Client service = new Service1Client();
                service.AgregarArtExtraviados(artEstraviados);
                service.Close();

            }

            ViewBag.idCategoria = new SelectList(db.Categoria, "idCategoria", "nombreCategoria", artEstraviados.idCategoria);
            return View(artEstraviados);
        }





        public ActionResult Create2()
        {
            ViewBag.idCategoria = new SelectList(db.Categoria, "idCategoria", "nombreCategoria");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create2([Bind(Include = "idArticuloExt,nombre,idCategoria,FechaIngreso,descripcion,IngresadoPor,Telefono_Contacto")] artEstraviados artEstraviados)
        {
            if (ModelState.IsValid)
            {
                /*db.artEstraviados.Add(artEstraviados);
                db.SaveChanges();
                ModelState.Clear();
                return RedirectToAction("Create2");*/

                Service1Client service = new Service1Client();
                service.AgregarArtExtraviados(artEstraviados);
                service.Close();
            }

            ViewBag.idCategoria = new SelectList(db.Categoria, "idCategoria", "nombreCategoria", artEstraviados.idCategoria);
            return View("../HomeGuest/Index");
        }






        // GET: artEstraviados/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            artEstraviados artEstraviados = db.artEstraviados.Find(id);
            if (artEstraviados == null)
            {
                return HttpNotFound();
            }
            return View(artEstraviados);
        }

        // POST: artEstraviados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            /* artEstraviados artEstraviados = db.artEstraviados.Find(id);
             db.artEstraviados.Remove(artEstraviados);
             db.SaveChanges();
             ;*/


            var sss = new artEstraviados();
            sss.idArticuloExt = id;

            Service1Client service = new Service1Client();
            service.EliminarArtExtraviados(sss);
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
