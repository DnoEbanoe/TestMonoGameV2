﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestGame.Client.GameService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GameService.IGameService")]
    public interface IGameService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/CreateGameObject", ReplyAction="http://tempuri.org/IGameService/CreateGameObjectResponse")]
        void CreateGameObject();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/CreateGameObject", ReplyAction="http://tempuri.org/IGameService/CreateGameObjectResponse")]
        System.Threading.Tasks.Task CreateGameObjectAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGameServiceChannel : TestGame.Client.GameService.IGameService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GameServiceClient : System.ServiceModel.ClientBase<TestGame.Client.GameService.IGameService>, TestGame.Client.GameService.IGameService {
        
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
        
        public void CreateGameObject() {
            base.Channel.CreateGameObject();
        }
        
        public System.Threading.Tasks.Task CreateGameObjectAsync() {
            return base.Channel.CreateGameObjectAsync();
        }
    }
}
