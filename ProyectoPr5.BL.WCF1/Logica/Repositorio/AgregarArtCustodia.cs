using ProyectoPr5.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPr5.BL.WCF1.Logica.Repositorio
{
    public class AgregarArtCustodia
    {

        public int agregarArtCustodia(artCustodia r) {


            BL.Clases.ManarticulosCustodia._Instancia.Insertar(r);

            return 1;

        }
    }
}