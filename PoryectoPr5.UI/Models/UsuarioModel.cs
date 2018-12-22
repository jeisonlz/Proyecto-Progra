using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoryectoPr5.UI.Models
{
    public class UsuarioModel
    {
        public string Cedula { set; get; }
        public string pass { set; get; }
        public int idUsuario { get; set; }
        public Nullable<int> idRol { get; set; }
        public string nombre { get; set; }
        public Nullable<int> telefono { get; set; }
        public string correo { get; set; }
    }
}