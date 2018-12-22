using ProyectoPr5.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPr5.BL.Interfaz
{
   public interface IManUsuarios
    {
        void Insertar(Usuarios Usuarios);
        List<Usuarios> Mostrar();
        void Actualizar(Usuarios Usuarios);
        void Eliminar(Usuarios Usuarios);
    }
}
