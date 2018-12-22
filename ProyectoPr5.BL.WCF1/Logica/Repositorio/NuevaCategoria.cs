using System;
using ProyectoPr5.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPr5.BL.WCF1.Logica.Repositorio
{
    public class NuevaCategoria
    {
        public int insertarCategoria(Categoria r)
        {

            List<Categoria> allUsers = new List<Categoria>();
            allUsers = ProyectoPr5.BL.Clases.ManCategoria._Instancia.Mostrar();

            int largo = Convert.ToInt32(allUsers.Count.ToString());
            bool ok = false;
            for (int i = 0; i < largo; i++)
            {
                string cedulaForm = (r.nombreCategoria);
                string cedulaBD = (allUsers[i].nombreCategoria.ToString());
                

                if (cedulaForm.ToLower().Equals(cedulaBD.ToLower()))
                {
                    ok = false;
                    i = largo + 1;
                }
                else
                {
                    ok = true;
                }

            }

            if (ok == true)
            {
                ProyectoPr5.BL.Clases.ManCategoria._Instancia.Insertar(r);
                return 1;

            }
            else
            {

                return 0;
            }

        }

    }
}