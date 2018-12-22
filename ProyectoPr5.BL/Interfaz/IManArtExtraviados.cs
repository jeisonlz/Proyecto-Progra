using ProyectoPr5.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPr5.BL.Interfaz
{
    public interface IManArtExtraviados
    {

        void Insertar(artEstraviados ArtEstraviados);
        List<artEstraviados> Mostrar();
        void Actualizar(artEstraviados ArtEstraviados);
        void Eliminar(artEstraviados ArtEstraviados);
    }
}
