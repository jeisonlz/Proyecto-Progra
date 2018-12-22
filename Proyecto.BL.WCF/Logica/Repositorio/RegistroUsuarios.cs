using ProyectoPr5.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPr5.BL.WCF.Logica.Repositorio
{
    public class RegistroUsuarios
    {

        public int insertarUsuarioNuevo(Usuarios r) {

            List<Usuarios> allUsers = new List<Usuarios>();
            allUsers = ProyectoPr5.BL.Clases.ManUsuarioss._Instancia.Mostrar();

            int largo = Convert.ToInt32(allUsers.Count.ToString());
            bool ok = false;
            for (int i = 0; i < largo; i++)
            {
                string cedulaForm = r.cedula;
                string cedulaBD = allUsers[i].cedula.ToString();

                if (cedulaForm.Equals(cedulaBD))
                {
                    ok = false;
                }
                else
                {
                    ok = true;
                }
            }

            if (ok == true)
            {
                ProyectoPr5.BL.Clases.ManUsuarioss._Instancia.Insertar(r);
                return 1;

            }
            else
            {

                return 0;
            }

        }
    }
}