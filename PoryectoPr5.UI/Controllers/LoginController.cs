using PoryectoPr5.UI.ServiceWCF;
using ProyectoPr5.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PoryectoPr5.UI.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View ();
        }

        [HttpPost]
        public ActionResult iniciar(Models.UsuarioModel r)
        {
           
                string cedula = r.Cedula;
                string pass = r.pass;

                string pagina = "Index";

                var init = new Models.LoginModel();
                bool ok = init.InicioSesion(cedula, pass);
            try
            {
                if (ok)
                {
                    int rs = init.Rol(cedula, pass);
                    if (rs == 0)
                    {
                        pagina = "../Home/Index";
                    }
                    else if (rs == 1)
                    {
                        pagina = "../HomeCustodia/Index";
                    }
                    else if (rs == 2)
                    {
                        pagina = "../HomeGuest/Index";
                    }

                }
                else
                {
                    TempData["msg"] = "<script>alert('Credenciales incorrectas');</script>";
                }
            }
            catch (Exception e) {
                TempData["msg"] = "<script>alert('Upps... Algo Salio Mal');</script>";
            }

            return View(pagina);


        }

        public ActionResult Registro()
        {
            return View();
        }


        [HttpPost]
        public ActionResult registrarUsuario(Models.UsuarioModel nuevo)
        {
            string pagina = "Index";
            Usuarios p = new Usuarios();
            p.cedula = nuevo.Cedula;
            p.pass = nuevo.pass;
            p.idRol = 2;
            p.nombre = nuevo.nombre;
            p.telefono = nuevo.telefono;
            p.correo = nuevo.correo;


            Service1Client service = new Service1Client();
            int ok=service.registrarUsuarioNuevo(p);

            if (ok == 1) {
               pagina = "Index";
            }
            else
            {
                TempData["msg"] = "<script>alert('Ya existe un Usuario con Esta Cedula');</script>";
                pagina = "Registro";
            }
            service.Close();
            return View(pagina);
        }
    }
}