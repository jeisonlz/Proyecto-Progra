using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoryectoPr5.UI.Models
{
    public class CategoriaModel
    {


     public int idCategoria { get; set; }
     public string nombreCategoria { get; set; }



        public int  devuelveNombre(string numero)
        {
            var query = (from a in ProyectoPr5.BL.Clases.ManCategoria._Instancia.Mostrar().AsEnumerable()
                         where (a.nombreCategoria == numero)
                         select new { a.idCategoria }).ToList();

            int cate=666666;

            foreach (var item in query)
            {
                cate = item.idCategoria;
            }

            return cate;
        }


        public List<string> muestraCategorias() {

            var query = (from a in ProyectoPr5.BL.Clases.ManCategoria._Instancia.Mostrar().AsEnumerable()
                       
                         select new { a.nombreCategoria}).ToList();

            var sss = new List<string>();

            foreach (var item in query)
            {
                sss.Add(item.nombreCategoria);
            }

            return sss;
        }
    }
}