using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPr5.DAL.Interfaz
{
   public interface IManCategoria
    {
        void Insertar(Categoria Categoria);
        List<Categoria> Mostrar();
        void Actualizar(Categoria Categoria);
        void Eliminar(Categoria Categoria);
    }
}
