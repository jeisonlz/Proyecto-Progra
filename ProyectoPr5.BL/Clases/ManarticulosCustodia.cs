using ProyectoPr5.BL.Interfaz;
using ProyectoPr5.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ProyectoPr5.BL.Clases
{
  public  class ManarticulosCustodia:IManarticulosCustodia
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
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManarticulosCustodia._Instancia.Actualizar(articulosCustodia);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(artCustodia articulosCustodia)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManarticulosCustodia._Instancia.Eliminar(articulosCustodia);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(artCustodia articulosCustodia)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManarticulosCustodia._Instancia.Insertar(articulosCustodia);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<artCustodia> Mostrar()
        {
            List<artCustodia> lista = new List<artCustodia>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.Clases.ManarticulosCustodia._Instancia.Mostrar();
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
