using ProyectoPr5.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoryectoPr5.UI.Models
{
    public class LoginModel
    {

        public bool InicioSesion(string ced, string pass)
        {

            List<Usuarios> allUser = new List<Usuarios>();
            allUser = ProyectoPr5.BL.Clases.ManUsuarioss._Instancia.Mostrar();

            int largo = Convert.ToInt32(allUser.Count.ToString());
            bool r = false;
            try
            {

                for (int i = 0; i < largo; i++)
                {
                    String user = allUser[i].cedula.ToString();
                    String passw = allUser[i].pass.ToString();


                    if (ced.Equals(user) && passw.Equals(pass))
                    {


                        r = true;
                    }

                }
            }
            catch (Exception e)
            {
            }

            return r;
        }


        public int Rol (string ced, string pass) {

            List<Usuarios> allUser = new List<Usuarios>();
            allUser = ProyectoPr5.BL.Clases.ManUsuarioss._Instancia.Mostrar();

            int largo = Convert.ToInt32(allUser.Count.ToString());
            int rol= 20;
            for (int i = 0; i < largo; i++)
            {
                String user = allUser[i].cedula.ToString();
                String passw = allUser[i].pass.ToString();


                if (ced.Equals(user) && passw.Equals(pass))
                {

                    rol= Convert.ToInt32(allUser[i].idRol.ToString());
                }

            
            }
            return rol;
        }
    }
}