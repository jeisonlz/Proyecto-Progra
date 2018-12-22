using ProyectoPr5.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPr5.BL.WCF1.Logica.Repositorio
{
    public class AgregarArtExtraviado
    {

        public int agregarArtExtra(artEstraviados r)
        {


            BL.Clases.ManArtExtraviados._Instancia.Insertar(r);

            return 1;

        }
    }
}