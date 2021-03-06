﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopClientGUI.ShopService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ShopService.IShopService")]
    public interface IShopService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopService/PostNote", ReplyAction="http://tempuri.org/IShopService/PostNoteResponse")]
        void PostNote(string from, string note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopService/PostNote", ReplyAction="http://tempuri.org/IShopService/PostNoteResponse")]
        System.Threading.Tasks.Task PostNoteAsync(string from, string note);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IShopServiceChannel : ShopClientGUI.ShopService.IShopService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ShopServiceClient : System.ServiceModel.ClientBase<ShopClientGUI.ShopService.IShopService>, ShopClientGUI.ShopService.IShopService {
        
        public ShopServiceClient() {
        }
        
        public ShopServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ShopServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ShopServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ShopServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void PostNote(string from, string note) {
            base.Channel.PostNote(from, note);
        }
        
        public System.Threading.Tasks.Task PostNoteAsync(string from, string note) {
            return base.Channel.PostNoteAsync(from, note);
        }
    }
}
