using ProyectoPr5.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPr5.BL.WCF1.Logica.Repositorio
{
    public class CambiarCategoria
    {
        public int ActualizarCategoria(Categoria r)
        {
            ProyectoPr5.BL.Clases.ManCategoria._Instancia.Actualizar(r);
            return 1;

        }

    }
}