using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPr5.DAL.Interfaz
{
    public interface IManArtExtraviados
    {
        void Insertar(artEstraviados artEstraviados);
        List<artEstraviados> Mostrar();
        void Actualizar(artEstraviados artEstraviados);
        void Eliminar(artEstraviados artEstraviados);
    }
}
