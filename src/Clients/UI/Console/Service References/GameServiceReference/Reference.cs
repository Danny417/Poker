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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GameServiceReference.IGameService")]
    public interface IGameService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/JoinGame", ReplyAction="http://tempuri.org/IGameService/JoinGameResponse")]
        string[] JoinGame(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/JoinGame", ReplyAction="http://tempuri.org/IGameService/JoinGameResponse")]
        System.Threading.Tasks.Task<string[]> JoinGameAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/QuitGame", ReplyAction="http://tempuri.org/IGameService/QuitGameResponse")]
        void QuitGame();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/QuitGame", ReplyAction="http://tempuri.org/IGameService/QuitGameResponse")]
        System.Threading.Tasks.Task QuitGameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/WatchGame", ReplyAction="http://tempuri.org/IGameService/WatchGameResponse")]
        void WatchGame();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/WatchGame", ReplyAction="http://tempuri.org/IGameService/WatchGameResponse")]
        System.Threading.Tasks.Task WatchGameAsync();
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
        
        public string[] JoinGame(string userName) {
            return base.Channel.JoinGame(userName);
        }
        
        public System.Threading.Tasks.Task<string[]> JoinGameAsync(string userName) {
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
    }
}