using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ProyectoPr5.DAL;

namespace ProyectoPr5.BL.WCF1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public int registrarUsuarioNuevo(Usuarios r)
        {

            var rs = new Logica.Repositorio.RegistroUsuarios();
            int ret = rs.insertarUsuarioNuevo(r);
            return ret;
        }

        public int CambiarRol(Usuarios r)
        {

            var rs = new Logica.Repositorio.CambiarRol();
            int ret = rs.insertarUsuarioNuevo(r);
            return ret;
        }

        public int NuevaCategoria(Categoria r)
        {
            var rs = new Logica.Repositorio.NuevaCategoria();
            int ret = rs.insertarCategoria(r);
            return ret;
        }

        public int CambiarCategoria(Categoria r)
        {
            var rs = new Logica.Repositorio.CambiarCategoria();
            int ret = rs.ActualizarCategoria(r);
            return ret;
        }

        public int AgregarArt(artCustodia r)
        {
            var rs = new Logica.Repositorio.AgregarArtCustodia();
            int ret = rs.agregarArtCustodia(r);
            return ret;
        }

        public int AgregarArtExtraviados(artEstraviados r)
        {
            var rs = new Logica.Repositorio.AgregarArtExtraviado();
            int ret =rs.agregarArtExtra(r);
            return ret;
        }

        public int EliminarArtExtraviados(artEstraviados r)
        {
            var rs = new Logica.Repositorio.EliminarArtExtraviado();
            var ret = rs.EliminarArtExtra(r);
            return ret;
        }

        public int EliminarArtCustodia(artCustodia r)
        {
            var rs = new Logica.Repositorio.EliminarArtCustodia();
            var ret = rs.EliminarArtCustodiaWcf(r);
            return ret;
        }
    }
}
