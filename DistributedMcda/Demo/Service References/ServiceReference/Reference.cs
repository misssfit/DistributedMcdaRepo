﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OperationStatus", Namespace="http://schemas.datacontract.org/2004/07/CalculatingEngine.Data")]
    [System.SerializableAttribute()]
    public partial class OperationStatus : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Demo.ServiceReference.RequestStatus StatusField;
        
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
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Demo.ServiceReference.RequestStatus Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RequestStatus", Namespace="http://schemas.datacontract.org/2004/07/CalculatingEngine.Data")]
    public enum RequestStatus : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Ok = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Error = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NotReady = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MethodDescription", Namespace="http://schemas.datacontract.org/2004/07/CalculatingEngine.Data")]
    [System.SerializableAttribute()]
    public partial class MethodDescription : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MethodNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] ParametersField;
        
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
        public string MethodName {
            get {
                return this.MethodNameField;
            }
            set {
                if ((object.ReferenceEquals(this.MethodNameField, value) != true)) {
                    this.MethodNameField = value;
                    this.RaisePropertyChanged("MethodName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] Parameters {
            get {
                return this.ParametersField;
            }
            set {
                if ((object.ReferenceEquals(this.ParametersField, value) != true)) {
                    this.ParametersField = value;
                    this.RaisePropertyChanged("Parameters");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CalculationResult", Namespace="http://schemas.datacontract.org/2004/07/CalculatingEngine.Data")]
    [System.SerializableAttribute()]
    public partial class CalculationResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double[][] DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Demo.ServiceReference.TaskStatus StatusField;
        
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
        public double[][] Data {
            get {
                return this.DataField;
            }
            set {
                if ((object.ReferenceEquals(this.DataField, value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Demo.ServiceReference.TaskStatus Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TaskStatus", Namespace="http://schemas.datacontract.org/2004/07/CalculatingEngine")]
    public enum TaskStatus : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NotStarted = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Calculated = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InProgress = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Corrupted = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.ICalculatingService")]
    public interface ICalculatingService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITaskDeleter/DeleteTask", ReplyAction="http://tempuri.org/ITaskDeleter/DeleteTaskResponse")]
        Demo.ServiceReference.OperationStatus DeleteTask(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITaskDeleter/DeleteTask", ReplyAction="http://tempuri.org/ITaskDeleter/DeleteTaskResponse")]
        System.Threading.Tasks.Task<Demo.ServiceReference.OperationStatus> DeleteTaskAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatingService/GetAllMethods", ReplyAction="http://tempuri.org/ICalculatingService/GetAllMethodsResponse")]
        Demo.ServiceReference.MethodDescription[] GetAllMethods();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatingService/GetAllMethods", ReplyAction="http://tempuri.org/ICalculatingService/GetAllMethodsResponse")]
        System.Threading.Tasks.Task<Demo.ServiceReference.MethodDescription[]> GetAllMethodsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatingService/Calculate", ReplyAction="http://tempuri.org/ICalculatingService/CalculateResponse")]
        Demo.ServiceReference.OperationStatus Calculate(string methodName, System.Collections.Generic.KeyValuePair<string, double[][]>[] inputParameters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatingService/Calculate", ReplyAction="http://tempuri.org/ICalculatingService/CalculateResponse")]
        System.Threading.Tasks.Task<Demo.ServiceReference.OperationStatus> CalculateAsync(string methodName, System.Collections.Generic.KeyValuePair<string, double[][]>[] inputParameters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatingService/GetResult", ReplyAction="http://tempuri.org/ICalculatingService/GetResultResponse")]
        Demo.ServiceReference.CalculationResult GetResult(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatingService/GetResult", ReplyAction="http://tempuri.org/ICalculatingService/GetResultResponse")]
        System.Threading.Tasks.Task<Demo.ServiceReference.CalculationResult> GetResultAsync(string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatingServiceChannel : Demo.ServiceReference.ICalculatingService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatingServiceClient : System.ServiceModel.ClientBase<Demo.ServiceReference.ICalculatingService>, Demo.ServiceReference.ICalculatingService {
        
        public CalculatingServiceClient() {
        }
        
        public CalculatingServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatingServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatingServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatingServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Demo.ServiceReference.OperationStatus DeleteTask(string id) {
            return base.Channel.DeleteTask(id);
        }
        
        public System.Threading.Tasks.Task<Demo.ServiceReference.OperationStatus> DeleteTaskAsync(string id) {
            return base.Channel.DeleteTaskAsync(id);
        }
        
        public Demo.ServiceReference.MethodDescription[] GetAllMethods() {
            return base.Channel.GetAllMethods();
        }
        
        public System.Threading.Tasks.Task<Demo.ServiceReference.MethodDescription[]> GetAllMethodsAsync() {
            return base.Channel.GetAllMethodsAsync();
        }
        
        public Demo.ServiceReference.OperationStatus Calculate(string methodName, System.Collections.Generic.KeyValuePair<string, double[][]>[] inputParameters) {
            return base.Channel.Calculate(methodName, inputParameters);
        }
        
        public System.Threading.Tasks.Task<Demo.ServiceReference.OperationStatus> CalculateAsync(string methodName, System.Collections.Generic.KeyValuePair<string, double[][]>[] inputParameters) {
            return base.Channel.CalculateAsync(methodName, inputParameters);
        }
        
        public Demo.ServiceReference.CalculationResult GetResult(string id) {
            return base.Channel.GetResult(id);
        }
        
        public System.Threading.Tasks.Task<Demo.ServiceReference.CalculationResult> GetResultAsync(string id) {
            return base.Channel.GetResultAsync(id);
        }
    }
}
