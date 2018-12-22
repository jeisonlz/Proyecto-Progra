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
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManArtExtraviados._Instancia.Actualizar(rs);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(artEstraviados rs)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManArtExtraviados._Instancia.Eliminar(rs);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(artEstraviados rs)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManArtExtraviados._Instancia.Insertar(rs);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<artEstraviados> Mostrar()
        {
            List<artEstraviados> lista = new List<artEstraviados>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.Clases.ManArtExtraviados._Instancia.Mostrar();
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
