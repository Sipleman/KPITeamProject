﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EP.DataBase {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DataBase.IDataBase")]
    public interface IDataBase {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataBase/Authorizate", ReplyAction="http://tempuri.org/IDataBase/AuthorizateResponse")]
        int Authorizate(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataBase/Authorizate", ReplyAction="http://tempuri.org/IDataBase/AuthorizateResponse")]
        System.Threading.Tasks.Task<int> AuthorizateAsync(string username, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataBaseChannel : EP.DataBase.IDataBase, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataBaseClient : System.ServiceModel.ClientBase<EP.DataBase.IDataBase>, EP.DataBase.IDataBase {
        
        public DataBaseClient() {
        }
        
        public DataBaseClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataBaseClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataBaseClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataBaseClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Authorizate(string username, string password) {
            return base.Channel.Authorizate(username, password);
        }
        
        public System.Threading.Tasks.Task<int> AuthorizateAsync(string username, string password) {
            return base.Channel.AuthorizateAsync(username, password);
        }
    }
}