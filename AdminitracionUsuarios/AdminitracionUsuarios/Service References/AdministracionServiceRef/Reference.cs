﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminitracionUsuarios.AdministracionServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TiposDocumento", Namespace="http://schemas.datacontract.org/2004/07/AdministracionUsuarios.WcfService.Entitie" +
        "s")]
    [System.SerializableAttribute()]
    public partial class TiposDocumento : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoDocumentoField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoDocumento {
            get {
                return this.TipoDocumentoField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoDocumentoField, value) != true)) {
                    this.TipoDocumentoField = value;
                    this.RaisePropertyChanged("TipoDocumento");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Usuario", Namespace="http://schemas.datacontract.org/2004/07/AdministracionUsuarios.WcfService.Entitie" +
        "s")]
    [System.SerializableAttribute()]
    public partial class Usuario : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CiudadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartamentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DireccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaNacimientoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreCompletoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumeroDocumentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PaisField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TipoDocumentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AdminitracionUsuarios.AdministracionServiceRef.TiposDocumento TipoDocumentoSelecionadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
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
        public string Ciudad {
            get {
                return this.CiudadField;
            }
            set {
                if ((object.ReferenceEquals(this.CiudadField, value) != true)) {
                    this.CiudadField = value;
                    this.RaisePropertyChanged("Ciudad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Departamento {
            get {
                return this.DepartamentoField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartamentoField, value) != true)) {
                    this.DepartamentoField = value;
                    this.RaisePropertyChanged("Departamento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Direccion {
            get {
                return this.DireccionField;
            }
            set {
                if ((object.ReferenceEquals(this.DireccionField, value) != true)) {
                    this.DireccionField = value;
                    this.RaisePropertyChanged("Direccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaNacimiento {
            get {
                return this.FechaNacimientoField;
            }
            set {
                if ((this.FechaNacimientoField.Equals(value) != true)) {
                    this.FechaNacimientoField = value;
                    this.RaisePropertyChanged("FechaNacimiento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreCompleto {
            get {
                return this.NombreCompletoField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreCompletoField, value) != true)) {
                    this.NombreCompletoField = value;
                    this.RaisePropertyChanged("NombreCompleto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumeroDocumento {
            get {
                return this.NumeroDocumentoField;
            }
            set {
                if ((object.ReferenceEquals(this.NumeroDocumentoField, value) != true)) {
                    this.NumeroDocumentoField = value;
                    this.RaisePropertyChanged("NumeroDocumento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Pais {
            get {
                return this.PaisField;
            }
            set {
                if ((object.ReferenceEquals(this.PaisField, value) != true)) {
                    this.PaisField = value;
                    this.RaisePropertyChanged("Pais");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TipoDocumento {
            get {
                return this.TipoDocumentoField;
            }
            set {
                if ((this.TipoDocumentoField.Equals(value) != true)) {
                    this.TipoDocumentoField = value;
                    this.RaisePropertyChanged("TipoDocumento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AdminitracionUsuarios.AdministracionServiceRef.TiposDocumento TipoDocumentoSelecionado {
            get {
                return this.TipoDocumentoSelecionadoField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoDocumentoSelecionadoField, value) != true)) {
                    this.TipoDocumentoSelecionadoField = value;
                    this.RaisePropertyChanged("TipoDocumentoSelecionado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AdministracionServiceRef.IAdministracionUsuariosServicio")]
    public interface IAdministracionUsuariosServicio {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministracionUsuariosServicio/GetTiposDocumentos", ReplyAction="http://tempuri.org/IAdministracionUsuariosServicio/GetTiposDocumentosResponse")]
        AdminitracionUsuarios.AdministracionServiceRef.TiposDocumento[] GetTiposDocumentos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministracionUsuariosServicio/GetTiposDocumentos", ReplyAction="http://tempuri.org/IAdministracionUsuariosServicio/GetTiposDocumentosResponse")]
        System.Threading.Tasks.Task<AdminitracionUsuarios.AdministracionServiceRef.TiposDocumento[]> GetTiposDocumentosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministracionUsuariosServicio/GetAll", ReplyAction="http://tempuri.org/IAdministracionUsuariosServicio/GetAllResponse")]
        AdminitracionUsuarios.AdministracionServiceRef.Usuario[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministracionUsuariosServicio/GetAll", ReplyAction="http://tempuri.org/IAdministracionUsuariosServicio/GetAllResponse")]
        System.Threading.Tasks.Task<AdminitracionUsuarios.AdministracionServiceRef.Usuario[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministracionUsuariosServicio/Get", ReplyAction="http://tempuri.org/IAdministracionUsuariosServicio/GetResponse")]
        AdminitracionUsuarios.AdministracionServiceRef.Usuario Get(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministracionUsuariosServicio/Get", ReplyAction="http://tempuri.org/IAdministracionUsuariosServicio/GetResponse")]
        System.Threading.Tasks.Task<AdminitracionUsuarios.AdministracionServiceRef.Usuario> GetAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministracionUsuariosServicio/Save", ReplyAction="http://tempuri.org/IAdministracionUsuariosServicio/SaveResponse")]
        bool Save(AdminitracionUsuarios.AdministracionServiceRef.Usuario entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministracionUsuariosServicio/Save", ReplyAction="http://tempuri.org/IAdministracionUsuariosServicio/SaveResponse")]
        System.Threading.Tasks.Task<bool> SaveAsync(AdminitracionUsuarios.AdministracionServiceRef.Usuario entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministracionUsuariosServicio/Edit", ReplyAction="http://tempuri.org/IAdministracionUsuariosServicio/EditResponse")]
        bool Edit(AdminitracionUsuarios.AdministracionServiceRef.Usuario entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministracionUsuariosServicio/Edit", ReplyAction="http://tempuri.org/IAdministracionUsuariosServicio/EditResponse")]
        System.Threading.Tasks.Task<bool> EditAsync(AdminitracionUsuarios.AdministracionServiceRef.Usuario entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministracionUsuariosServicio/Delete", ReplyAction="http://tempuri.org/IAdministracionUsuariosServicio/DeleteResponse")]
        bool Delete(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministracionUsuariosServicio/Delete", ReplyAction="http://tempuri.org/IAdministracionUsuariosServicio/DeleteResponse")]
        System.Threading.Tasks.Task<bool> DeleteAsync(string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAdministracionUsuariosServicioChannel : AdminitracionUsuarios.AdministracionServiceRef.IAdministracionUsuariosServicio, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AdministracionUsuariosServicioClient : System.ServiceModel.ClientBase<AdminitracionUsuarios.AdministracionServiceRef.IAdministracionUsuariosServicio>, AdminitracionUsuarios.AdministracionServiceRef.IAdministracionUsuariosServicio {
        
        public AdministracionUsuariosServicioClient() {
        }
        
        public AdministracionUsuariosServicioClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AdministracionUsuariosServicioClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdministracionUsuariosServicioClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdministracionUsuariosServicioClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AdminitracionUsuarios.AdministracionServiceRef.TiposDocumento[] GetTiposDocumentos() {
            return base.Channel.GetTiposDocumentos();
        }
        
        public System.Threading.Tasks.Task<AdminitracionUsuarios.AdministracionServiceRef.TiposDocumento[]> GetTiposDocumentosAsync() {
            return base.Channel.GetTiposDocumentosAsync();
        }
        
        public AdminitracionUsuarios.AdministracionServiceRef.Usuario[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<AdminitracionUsuarios.AdministracionServiceRef.Usuario[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public AdminitracionUsuarios.AdministracionServiceRef.Usuario Get(string id) {
            return base.Channel.Get(id);
        }
        
        public System.Threading.Tasks.Task<AdminitracionUsuarios.AdministracionServiceRef.Usuario> GetAsync(string id) {
            return base.Channel.GetAsync(id);
        }
        
        public bool Save(AdminitracionUsuarios.AdministracionServiceRef.Usuario entity) {
            return base.Channel.Save(entity);
        }
        
        public System.Threading.Tasks.Task<bool> SaveAsync(AdminitracionUsuarios.AdministracionServiceRef.Usuario entity) {
            return base.Channel.SaveAsync(entity);
        }
        
        public bool Edit(AdminitracionUsuarios.AdministracionServiceRef.Usuario entity) {
            return base.Channel.Edit(entity);
        }
        
        public System.Threading.Tasks.Task<bool> EditAsync(AdminitracionUsuarios.AdministracionServiceRef.Usuario entity) {
            return base.Channel.EditAsync(entity);
        }
        
        public bool Delete(string id) {
            return base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAsync(string id) {
            return base.Channel.DeleteAsync(id);
        }
    }
}
