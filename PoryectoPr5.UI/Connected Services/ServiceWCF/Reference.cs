﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PoryectoPr5.UI.ServiceWCF {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/ProyectoPr5.BL.WCF1")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceWCF.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/registrarUsuarioNuevo", ReplyAction="http://tempuri.org/IService1/registrarUsuarioNuevoResponse")]
        int registrarUsuarioNuevo(ProyectoPr5.DAL.Usuarios r);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/registrarUsuarioNuevo", ReplyAction="http://tempuri.org/IService1/registrarUsuarioNuevoResponse")]
        System.Threading.Tasks.Task<int> registrarUsuarioNuevoAsync(ProyectoPr5.DAL.Usuarios r);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CambiarRol", ReplyAction="http://tempuri.org/IService1/CambiarRolResponse")]
        int CambiarRol(ProyectoPr5.DAL.Usuarios r);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CambiarRol", ReplyAction="http://tempuri.org/IService1/CambiarRolResponse")]
        System.Threading.Tasks.Task<int> CambiarRolAsync(ProyectoPr5.DAL.Usuarios r);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NuevaCategoria", ReplyAction="http://tempuri.org/IService1/NuevaCategoriaResponse")]
        int NuevaCategoria(ProyectoPr5.DAL.Categoria r);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NuevaCategoria", ReplyAction="http://tempuri.org/IService1/NuevaCategoriaResponse")]
        System.Threading.Tasks.Task<int> NuevaCategoriaAsync(ProyectoPr5.DAL.Categoria r);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CambiarCategoria", ReplyAction="http://tempuri.org/IService1/CambiarCategoriaResponse")]
        int CambiarCategoria(ProyectoPr5.DAL.Categoria r);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CambiarCategoria", ReplyAction="http://tempuri.org/IService1/CambiarCategoriaResponse")]
        System.Threading.Tasks.Task<int> CambiarCategoriaAsync(ProyectoPr5.DAL.Categoria r);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AgregarArt", ReplyAction="http://tempuri.org/IService1/AgregarArtResponse")]
        int AgregarArt(ProyectoPr5.DAL.artCustodia r);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AgregarArt", ReplyAction="http://tempuri.org/IService1/AgregarArtResponse")]
        System.Threading.Tasks.Task<int> AgregarArtAsync(ProyectoPr5.DAL.artCustodia r);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AgregarArtExtraviados", ReplyAction="http://tempuri.org/IService1/AgregarArtExtraviadosResponse")]
        int AgregarArtExtraviados(ProyectoPr5.DAL.artEstraviados r);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AgregarArtExtraviados", ReplyAction="http://tempuri.org/IService1/AgregarArtExtraviadosResponse")]
        System.Threading.Tasks.Task<int> AgregarArtExtraviadosAsync(ProyectoPr5.DAL.artEstraviados r);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EliminarArtExtraviados", ReplyAction="http://tempuri.org/IService1/EliminarArtExtraviadosResponse")]
        int EliminarArtExtraviados(ProyectoPr5.DAL.artEstraviados r);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EliminarArtExtraviados", ReplyAction="http://tempuri.org/IService1/EliminarArtExtraviadosResponse")]
        System.Threading.Tasks.Task<int> EliminarArtExtraviadosAsync(ProyectoPr5.DAL.artEstraviados r);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EliminarArtCustodia", ReplyAction="http://tempuri.org/IService1/EliminarArtCustodiaResponse")]
        int EliminarArtCustodia(ProyectoPr5.DAL.artCustodia r);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EliminarArtCustodia", ReplyAction="http://tempuri.org/IService1/EliminarArtCustodiaResponse")]
        System.Threading.Tasks.Task<int> EliminarArtCustodiaAsync(ProyectoPr5.DAL.artCustodia r);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        PoryectoPr5.UI.ServiceWCF.CompositeType GetDataUsingDataContract(PoryectoPr5.UI.ServiceWCF.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<PoryectoPr5.UI.ServiceWCF.CompositeType> GetDataUsingDataContractAsync(PoryectoPr5.UI.ServiceWCF.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : PoryectoPr5.UI.ServiceWCF.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<PoryectoPr5.UI.ServiceWCF.IService1>, PoryectoPr5.UI.ServiceWCF.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int registrarUsuarioNuevo(ProyectoPr5.DAL.Usuarios r) {
            return base.Channel.registrarUsuarioNuevo(r);
        }
        
        public System.Threading.Tasks.Task<int> registrarUsuarioNuevoAsync(ProyectoPr5.DAL.Usuarios r) {
            return base.Channel.registrarUsuarioNuevoAsync(r);
        }
        
        public int CambiarRol(ProyectoPr5.DAL.Usuarios r) {
            return base.Channel.CambiarRol(r);
        }
        
        public System.Threading.Tasks.Task<int> CambiarRolAsync(ProyectoPr5.DAL.Usuarios r) {
            return base.Channel.CambiarRolAsync(r);
        }
        
        public int NuevaCategoria(ProyectoPr5.DAL.Categoria r) {
            return base.Channel.NuevaCategoria(r);
        }
        
        public System.Threading.Tasks.Task<int> NuevaCategoriaAsync(ProyectoPr5.DAL.Categoria r) {
            return base.Channel.NuevaCategoriaAsync(r);
        }
        
        public int CambiarCategoria(ProyectoPr5.DAL.Categoria r) {
            return base.Channel.CambiarCategoria(r);
        }
        
        public System.Threading.Tasks.Task<int> CambiarCategoriaAsync(ProyectoPr5.DAL.Categoria r) {
            return base.Channel.CambiarCategoriaAsync(r);
        }
        
        public int AgregarArt(ProyectoPr5.DAL.artCustodia r) {
            return base.Channel.AgregarArt(r);
        }
        
        public System.Threading.Tasks.Task<int> AgregarArtAsync(ProyectoPr5.DAL.artCustodia r) {
            return base.Channel.AgregarArtAsync(r);
        }
        
        public int AgregarArtExtraviados(ProyectoPr5.DAL.artEstraviados r) {
            return base.Channel.AgregarArtExtraviados(r);
        }
        
        public System.Threading.Tasks.Task<int> AgregarArtExtraviadosAsync(ProyectoPr5.DAL.artEstraviados r) {
            return base.Channel.AgregarArtExtraviadosAsync(r);
        }
        
        public int EliminarArtExtraviados(ProyectoPr5.DAL.artEstraviados r) {
            return base.Channel.EliminarArtExtraviados(r);
        }
        
        public System.Threading.Tasks.Task<int> EliminarArtExtraviadosAsync(ProyectoPr5.DAL.artEstraviados r) {
            return base.Channel.EliminarArtExtraviadosAsync(r);
        }
        
        public int EliminarArtCustodia(ProyectoPr5.DAL.artCustodia r) {
            return base.Channel.EliminarArtCustodia(r);
        }
        
        public System.Threading.Tasks.Task<int> EliminarArtCustodiaAsync(ProyectoPr5.DAL.artCustodia r) {
            return base.Channel.EliminarArtCustodiaAsync(r);
        }
        
        public PoryectoPr5.UI.ServiceWCF.CompositeType GetDataUsingDataContract(PoryectoPr5.UI.ServiceWCF.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<PoryectoPr5.UI.ServiceWCF.CompositeType> GetDataUsingDataContractAsync(PoryectoPr5.UI.ServiceWCF.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
