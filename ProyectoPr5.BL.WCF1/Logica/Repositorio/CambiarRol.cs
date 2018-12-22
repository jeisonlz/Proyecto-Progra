using ProyectoPr5.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPr5.BL.WCF1.Logica.Repositorio
{
    public class CambiarRol
    {

        public int insertarUsuarioNuevo(Usuarios r)
        {
             ProyectoPr5.BL.Clases.ManUsuarioss._Instancia.Actualizar(r);
            return 1;

        }
    }
}