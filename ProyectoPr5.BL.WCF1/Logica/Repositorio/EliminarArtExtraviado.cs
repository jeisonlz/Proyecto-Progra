using ProyectoPr5.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPr5.BL.WCF1.Logica.Repositorio
{
    public class EliminarArtExtraviado
    {
        public int EliminarArtExtra(artEstraviados r)
        {


            BL.Clases.ManArtExtraviados._Instancia.Eliminar(r);

            return 1;

        }
    }
}