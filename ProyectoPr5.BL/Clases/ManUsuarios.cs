using ProyectoPr5.BL.Interfaz;
using ProyectoPr5.DAL;
using ProyectoPr5.DAL.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ProyectoPr5.BL.Clases
{
   public class ManUsuarioss:IManUsuarios
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
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManUsuarios._Instancia.Actualizar(Usuarios);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(Usuarios Usuarios)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManUsuarios._Instancia.Eliminar(Usuarios);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(Usuarios Usuarios)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManUsuarios._Instancia.Insertar(Usuarios);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<Usuarios> Mostrar()
        {
            List<Usuarios> lista = new List<Usuarios>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.Clases.ManUsuarios._Instancia.Mostrar();
                    scope.Complete();
                }
                return lista;
            }
            catch (Exception ee)
            {

                throw;
            }
        }
    }
}
