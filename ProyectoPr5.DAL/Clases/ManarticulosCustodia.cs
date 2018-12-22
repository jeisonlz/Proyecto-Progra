using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPr5.DAL.Clases
{
    public class ManarticulosCustodia
    {
        private static ManarticulosCustodia Instancia;

        public static ManarticulosCustodia _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManarticulosCustodia();
                }
                return Instancia;
            }
            set
            {
                if (Instancia == null)
                {
                    Instancia = value;
                }
            }
        }
        public void Actualizar(artCustodia articulosCustodia)
        {
            try
            {
                using (ProyectoPR5Entities entities = new ProyectoPR5Entities())
                {
                    entities.Entry(articulosCustodia).State = System.Data.Entity.EntityState.Modified;
                    entities.SaveChanges();
                }
            }
            catch (Exception ee)
            {

                
            }
        }


        public void Eliminar(artCustodia articulosCustodia)
        {
            try
            {
                ProyectoPR5Entities entities = new ProyectoPR5Entities();
                var result = entities.artCustodia.Find(articulosCustodia.idArticuloCus);
                entities.artCustodia.Remove(result);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

            
            }
        }

        public void Insertar(artCustodia articulosCustodia)
        {
            try
            {
                ProyectoPR5Entities entities = new ProyectoPR5Entities();
                entities.artCustodia.Add(articulosCustodia);
                entities.SaveChanges();
              

            }
            catch (Exception ee)
            {

            }
        }

        public List<artCustodia> Mostrar()
        {
            //Inicializamos
            List<artCustodia> lista = new List<artCustodia>();

            try
            {
                ProyectoPR5Entities entities = new ProyectoPR5Entities();
                lista = entities.artCustodia.ToList();
                entities.SaveChanges();

                return lista;
            }
            catch (Exception ee)
            {

                throw;
            }
        }

    }
}
