﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Poker.Clients.UI.Console.GameServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Player", Namespace="http://schemas.datacontract.org/2004/07/Poker.Service.Contracts.Entities")]
    [System.SerializableAttribute()]
    public partial class Player : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] MessagesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Poker.Clients.UI.Console.GameServiceReference.Card[] StartingCardsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid UniqueIdentifierField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public string[] Messages {
            get {
                return this.MessagesField;
            }
            set {
                if ((object.ReferenceEquals(this.MessagesField, value) != true)) {
                    this.MessagesField = value;
                    this.RaisePropertyChanged("Messages");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Poker.Clients.UI.Console.GameServiceReference.Card[] StartingCards {
            get {
                return this.StartingCardsField;
            }
            set {
                if ((object.ReferenceEquals(this.StartingCardsField, value) != true)) {
                    this.StartingCardsField = value;
                    this.RaisePropertyChanged("StartingCards");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int State {
            get {
                return this.StateField;
            }
            set {
                if ((this.StateField.Equals(value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid UniqueIdentifier {
            get {
                return this.UniqueIdentifierField;
            }
            set {
                if ((this.UniqueIdentifierField.Equals(value) != true)) {
                    this.UniqueIdentifierField = value;
                    this.RaisePropertyChanged("UniqueIdentifier");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Card", Namespace="http://schemas.datacontract.org/2004/07/Poker.Service.Contracts.Entities")]
    [System.SerializableAttribute()]
    public partial class Card : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Poker.Clients.UI.Console.GameServiceReference.CardRank RankField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Poker.Clients.UI.Console.GameServiceReference.CardSuit SuitField;
        
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
        public Poker.Clients.UI.Console.GameServiceReference.CardRank Rank {
            get {
                return this.RankField;
            }
            set {
                if ((this.RankField.Equals(value) != true)) {
                    this.RankField = value;
                    this.RaisePropertyChanged("Rank");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Poker.Clients.UI.Console.GameServiceReference.CardSuit Suit {
            get {
                return this.SuitField;
            }
            set {
                if ((this.SuitField.Equals(value) != true)) {
                    this.SuitField = value;
                    this.RaisePropertyChanged("Suit");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CardRank", Namespace="http://schemas.datacontract.org/2004/07/Poker.Service.Contracts.Entities")]
    public enum CardRank : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Ace = 14,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        King = 13,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Queen = 12,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Jack = 11,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Ten = 10,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Nine = 9,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Eight = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Seven = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Six = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Five = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Four = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Three = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Two = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CardSuit", Namespace="http://schemas.datacontract.org/2004/07/Poker.Service.Contracts.Entities")]
    public enum CardSuit : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Spade = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Heart = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Diamond = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Club = 0,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GameServiceReference.IGameService")]
    public interface IGameService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/JoinGame", ReplyAction="http://tempuri.org/IGameService/JoinGameResponse")]
        Poker.Clients.UI.Console.GameServiceReference.Player JoinGame(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/JoinGame", ReplyAction="http://tempuri.org/IGameService/JoinGameResponse")]
        System.Threading.Tasks.Task<Poker.Clients.UI.Console.GameServiceReference.Player> JoinGameAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/QuitGame", ReplyAction="http://tempuri.org/IGameService/QuitGameResponse")]
        void QuitGame();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/QuitGame", ReplyAction="http://tempuri.org/IGameService/QuitGameResponse")]
        System.Threading.Tasks.Task QuitGameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/WatchGame", ReplyAction="http://tempuri.org/IGameService/WatchGameResponse")]
        void WatchGame();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/WatchGame", ReplyAction="http://tempuri.org/IGameService/WatchGameResponse")]
        System.Threading.Tasks.Task WatchGameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/Update", ReplyAction="http://tempuri.org/IGameService/UpdateResponse")]
        string[] Update(System.Guid uid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/Update", ReplyAction="http://tempuri.org/IGameService/UpdateResponse")]
        System.Threading.Tasks.Task<string[]> UpdateAsync(System.Guid uid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/Chat", ReplyAction="http://tempuri.org/IGameService/ChatResponse")]
        void Chat(System.Guid uid, string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/Chat", ReplyAction="http://tempuri.org/IGameService/ChatResponse")]
        System.Threading.Tasks.Task ChatAsync(System.Guid uid, string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGameServiceChannel : Poker.Clients.UI.Console.GameServiceReference.IGameService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GameServiceClient : System.ServiceModel.ClientBase<Poker.Clients.UI.Console.GameServiceReference.IGameService>, Poker.Clients.UI.Console.GameServiceReference.IGameService {
        
        public GameServiceClient() {
        }
        
        public GameServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GameServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GameServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GameServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Poker.Clients.UI.Console.GameServiceReference.Player JoinGame(string userName) {
            return base.Channel.JoinGame(userName);
        }
        
        public System.Threading.Tasks.Task<Poker.Clients.UI.Console.GameServiceReference.Player> JoinGameAsync(string userName) {
            return base.Channel.JoinGameAsync(userName);
        }
        
        public void QuitGame() {
            base.Channel.QuitGame();
        }
        
        public System.Threading.Tasks.Task QuitGameAsync() {
            return base.Channel.QuitGameAsync();
        }
        
        public void WatchGame() {
            base.Channel.WatchGame();
        }
        
        public System.Threading.Tasks.Task WatchGameAsync() {
            return base.Channel.WatchGameAsync();
        }
        
        public string[] Update(System.Guid uid) {
            return base.Channel.Update(uid);
        }
        
        public System.Threading.Tasks.Task<string[]> UpdateAsync(System.Guid uid) {
            return base.Channel.UpdateAsync(uid);
        }
        
        public void Chat(System.Guid uid, string message) {
            base.Channel.Chat(uid, message);
        }
        
        public System.Threading.Tasks.Task ChatAsync(System.Guid uid, string message) {
            return base.Channel.ChatAsync(uid, message);
        }
    }
}