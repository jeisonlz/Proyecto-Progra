using ProyectoPr5.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ProyectoPr5.BL.WCF1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int registrarUsuarioNuevo(Usuarios r);

        [OperationContract]
        int CambiarRol(Usuarios r);

        [OperationContract]
        int NuevaCategoria(Categoria r);

        [OperationContract]
        int CambiarCategoria(Categoria r);

        [OperationContract]
        int AgregarArt(artCustodia r);

        [OperationContract]
        int AgregarArtExtraviados(artEstraviados r);

        [OperationContract]
        int EliminarArtExtraviados(artEstraviados r);

        [OperationContract]
        int EliminarArtCustodia(artCustodia r);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
