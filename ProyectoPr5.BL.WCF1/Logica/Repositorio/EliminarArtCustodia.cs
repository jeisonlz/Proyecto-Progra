using ProyectoPr5.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPr5.BL.WCF1.Logica.Repositorio
{
    public class EliminarArtCustodia
    {
        public int EliminarArtCustodiaWcf (artCustodia r)
        {


            BL.Clases.ManarticulosCustodia._Instancia.Eliminar(r);

            return 1;

        }
    }
}