using ProyectoPr5.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoryectoPr5.UI.Models
{
    public class InfoUsuarios
    {

        public List<Usuarios> TodosLosUsuarios() {

            var allUserInfo = ProyectoPr5.BL.Clases.ManUsuarioss._Instancia.Mostrar();

            return allUserInfo;
        }


        public Usuarios DatosbyID(int? IdPersona) {
            Nullable<int> pp = IdPersona;
            var persona = new Usuarios();

            var allUserInfo = ProyectoPr5.BL.Clases.ManUsuarioss._Instancia.Mostrar();
            var lista = new List<Usuarios>();

            lista = (allUserInfo.Where(p => p.idUsuario == pp)).ToList();

            foreach (var item in lista)
            {
                persona.idUsuario = item.idUsuario;
                persona.cedula = item.cedula;
                persona.idRol = item.idRol;
                persona.pass = item.pass;
            }

            return persona;
        }
    }
}