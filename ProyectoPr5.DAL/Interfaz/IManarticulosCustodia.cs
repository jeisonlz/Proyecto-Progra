using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPr5.DAL.Interfaz
{
   public interface IManarticulosCustodia
    {

        void Insertar(artCustodia artCustodia);
        List<artCustodia> Mostrar();
        void Actualizar(artCustodia artCustodia);
        void Eliminar(artCustodia artCustodia);
    }
}
