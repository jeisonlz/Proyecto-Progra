using ProyectoPr5.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPr5.BL.WCF1.Logica.Repositorio
{
    public class RegistroUsuarios
    {
        public int insertarUsuarioNuevo(Usuarios r)
        {

            List<Usuarios> allUsers = new List<Usuarios>();
            allUsers = ProyectoPr5.BL.Clases.ManUsuarioss._Instancia.Mostrar();

            int largo = Convert.ToInt32(allUsers.Count.ToString());
            bool ok = false;
            for (int i = 0; i < largo; i++)
            {
                int cedulaForm = Convert.ToInt32(r.cedula);
                int cedulaBD = Convert.ToInt32(allUsers[i].cedula.ToString());

                if (cedulaForm == cedulaBD)
                {
                    ok = false;
                    i=largo+1;
                }
                else {
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