using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPr5.DAL.Clases
{
    public class ManCategoria
    {
        private static ManCategoria Instancia;

        public static ManCategoria _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManCategoria();
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
        public void Actualizar(Categoria Categoria)
        {
            try
            {
                using (ProyectoPR5Entities entities = new ProyectoPR5Entities())
                {
                    entities.Entry(Categoria).State = System.Data.Entity.EntityState.Modified;
                    entities.SaveChanges();
                }
            }
            catch (Exception ee)
            {

                
            }
        }


        public void Eliminar(Categoria Categoria)
        {
            try
            {
                ProyectoPR5Entities entities = new ProyectoPR5Entities();
                var result = entities.Categoria.Find(Categoria.idCategoria);
                entities.Categoria.Remove(result);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                
            }
        }

        public void Insertar(Categoria Categoria)
        {
            try
            {
                ProyectoPR5Entities entities = new ProyectoPR5Entities();
                entities.Categoria.Add(Categoria);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

               
            }
        }

        public List<Categoria> Mostrar()
        {
            //Inicializamos
            List<Categoria> lista = new List<Categoria>();

            try
            {
                ProyectoPR5Entities entities = new ProyectoPR5Entities();
                lista = entities.Categoria.ToList();
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
