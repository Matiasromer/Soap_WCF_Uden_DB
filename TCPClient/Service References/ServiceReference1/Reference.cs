﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TCPClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Game", Namespace="http://schemas.datacontract.org/2004/07/Soap_WCF_Uden_DB")]
    [System.SerializableAttribute()]
    public partial class Game : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double RatingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitelField;
        
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
        public double Rating {
            get {
                return this.RatingField;
            }
            set {
                if ((this.RatingField.Equals(value) != true)) {
                    this.RatingField = value;
                    this.RaisePropertyChanged("Rating");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Titel {
            get {
                return this.TitelField;
            }
            set {
                if ((object.ReferenceEquals(this.TitelField, value) != true)) {
                    this.TitelField = value;
                    this.RaisePropertyChanged("Titel");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetGame", ReplyAction="http://tempuri.org/IService1/GetGameResponse")]
        TCPClient.ServiceReference1.Game[] GetGame();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetGame", ReplyAction="http://tempuri.org/IService1/GetGameResponse")]
        System.Threading.Tasks.Task<TCPClient.ServiceReference1.Game[]> GetGameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddGame", ReplyAction="http://tempuri.org/IService1/AddGameResponse")]
        void AddGame(TCPClient.ServiceReference1.Game newGame);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddGame", ReplyAction="http://tempuri.org/IService1/AddGameResponse")]
        System.Threading.Tasks.Task AddGameAsync(TCPClient.ServiceReference1.Game newGame);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteGame", ReplyAction="http://tempuri.org/IService1/DeleteGameResponse")]
        void DeleteGame([System.ServiceModel.MessageParameterAttribute(Name="deleteGame")] TCPClient.ServiceReference1.Game deleteGame1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteGame", ReplyAction="http://tempuri.org/IService1/DeleteGameResponse")]
        System.Threading.Tasks.Task DeleteGameAsync(TCPClient.ServiceReference1.Game deleteGame);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateGame", ReplyAction="http://tempuri.org/IService1/UpdateGameResponse")]
        void UpdateGame(int id, TCPClient.ServiceReference1.Game game);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateGame", ReplyAction="http://tempuri.org/IService1/UpdateGameResponse")]
        System.Threading.Tasks.Task UpdateGameAsync(int id, TCPClient.ServiceReference1.Game game);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : TCPClient.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<TCPClient.ServiceReference1.IService1>, TCPClient.ServiceReference1.IService1 {
        
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
        
        public TCPClient.ServiceReference1.Game[] GetGame() {
            return base.Channel.GetGame();
        }
        
        public System.Threading.Tasks.Task<TCPClient.ServiceReference1.Game[]> GetGameAsync() {
            return base.Channel.GetGameAsync();
        }
        
        public void AddGame(TCPClient.ServiceReference1.Game newGame) {
            base.Channel.AddGame(newGame);
        }
        
        public System.Threading.Tasks.Task AddGameAsync(TCPClient.ServiceReference1.Game newGame) {
            return base.Channel.AddGameAsync(newGame);
        }
        
        public void DeleteGame(TCPClient.ServiceReference1.Game deleteGame1) {
            base.Channel.DeleteGame(deleteGame1);
        }
        
        public System.Threading.Tasks.Task DeleteGameAsync(TCPClient.ServiceReference1.Game deleteGame) {
            return base.Channel.DeleteGameAsync(deleteGame);
        }
        
        public void UpdateGame(int id, TCPClient.ServiceReference1.Game game) {
            base.Channel.UpdateGame(id, game);
        }
        
        public System.Threading.Tasks.Task UpdateGameAsync(int id, TCPClient.ServiceReference1.Game game) {
            return base.Channel.UpdateGameAsync(id, game);
        }
    }
}
