using ProyectoPr5.DAL.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPr5.DAL.Clases
{
    public class ManArtExtraviados: IManArtExtraviados
    {
        private static ManArtExtraviados Instancia;

        public static ManArtExtraviados _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManArtExtraviados();
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
        public void Actualizar(artEstraviados rs)
        {
            try
            {
                using (ProyectoPR5Entities entities = new ProyectoPR5Entities())
                {
                    entities.Entry(rs).State = System.Data.Entity.EntityState.Modified;
                    entities.SaveChanges();
                }
            }
            catch (Exception ee)
            {

                
            }
        }


        public void Eliminar(artEstraviados rs)
        {
            try
            {
                ProyectoPR5Entities entities = new ProyectoPR5Entities();
                var result = entities.artEstraviados.Find(rs.idArticuloExt);
                entities.artEstraviados.Remove(result);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {
                
            }
        }

        public void Insertar(artEstraviados rs)
        {
            try
            {
                ProyectoPR5Entities entities = new ProyectoPR5Entities();
                entities.artEstraviados.Add(rs);
                entities.SaveChanges();


            }
            catch (Exception ee)
            {

             
            }
        }

        public List<artEstraviados> Mostrar()
        {
            //Inicializamos
            List<artEstraviados> lista = new List<artEstraviados>();

            try
            {
                ProyectoPR5Entities entities = new ProyectoPR5Entities();
                lista = entities.artEstraviados.ToList();
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
