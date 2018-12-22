using ProyectoPr5.DAL.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPr5.DAL.Clases
{
   public class ManUsuarios:IManUsuarios
    {
        private static ManUsuarios Instancia;

        public static ManUsuarios _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManUsuarios();
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
        public void Actualizar(Usuarios Usuarios)
        {
            try
            {
                using (ProyectoPR5Entities entities = new ProyectoPR5Entities())
                {
                    entities.Entry(Usuarios).State = System.Data.Entity.EntityState.Modified;
                    entities.SaveChanges();
                }
            }
            catch (Exception ee)
            {

               
            }
        }


        public void Eliminar(Usuarios Usuarios)
        {
            try
            {
                ProyectoPR5Entities entities = new ProyectoPR5Entities();
                var result = entities.Usuarios.Find(Usuarios.idUsuario);
                entities.Usuarios.Remove(result);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                
            }
        }

        public void Insertar(Usuarios Usuarios)
        {
            try
            {
                ProyectoPR5Entities entities = new ProyectoPR5Entities();
                entities.Usuarios.Add(Usuarios);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

               
            }
        }

        public List<Usuarios> Mostrar()
        {
            //Inicializamos
            List<Usuarios> lista = new List<Usuarios>();

            try
            {
                ProyectoPR5Entities entities = new ProyectoPR5Entities();
                lista = entities.Usuarios.ToList();
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
