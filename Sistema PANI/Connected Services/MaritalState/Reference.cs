﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema_PANI.MaritalState {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="KeyValuePairDTO", Namespace="http://schemas.datacontract.org/2004/07/Adoption.Contract.DataContract")]
    [System.SerializableAttribute()]
    public partial class KeyValuePairDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MaritalState.IMaritalStateServices")]
    public interface IMaritalStateServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaritalStateServices/GetMaritalStates", ReplyAction="http://tempuri.org/IMaritalStateServices/GetMaritalStatesResponse")]
        Sistema_PANI.MaritalState.KeyValuePairDTO[] GetMaritalStates();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaritalStateServices/GetMaritalStates", ReplyAction="http://tempuri.org/IMaritalStateServices/GetMaritalStatesResponse")]
        System.Threading.Tasks.Task<Sistema_PANI.MaritalState.KeyValuePairDTO[]> GetMaritalStatesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMaritalStateServicesChannel : Sistema_PANI.MaritalState.IMaritalStateServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MaritalStateServicesClient : System.ServiceModel.ClientBase<Sistema_PANI.MaritalState.IMaritalStateServices>, Sistema_PANI.MaritalState.IMaritalStateServices {
        
        public MaritalStateServicesClient() {
        }
        
        public MaritalStateServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MaritalStateServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MaritalStateServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MaritalStateServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Sistema_PANI.MaritalState.KeyValuePairDTO[] GetMaritalStates() {
            return base.Channel.GetMaritalStates();
        }
        
        public System.Threading.Tasks.Task<Sistema_PANI.MaritalState.KeyValuePairDTO[]> GetMaritalStatesAsync() {
            return base.Channel.GetMaritalStatesAsync();
        }
    }
}
