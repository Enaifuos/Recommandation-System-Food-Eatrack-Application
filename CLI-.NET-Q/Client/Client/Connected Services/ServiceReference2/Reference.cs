﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IUserProfil")]
    public interface IUserProfil {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfil/addToFridge", ReplyAction="http://tempuri.org/IUserProfil/addToFridgeResponse")]
        string addToFridge(string[] args);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfil/addToFridge", ReplyAction="http://tempuri.org/IUserProfil/addToFridgeResponse")]
        System.Threading.Tasks.Task<string> addToFridgeAsync(string[] args);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfil/removeFromFridge", ReplyAction="http://tempuri.org/IUserProfil/removeFromFridgeResponse")]
        string removeFromFridge(string[] args);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfil/removeFromFridge", ReplyAction="http://tempuri.org/IUserProfil/removeFromFridgeResponse")]
        System.Threading.Tasks.Task<string> removeFromFridgeAsync(string[] args);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfil/inquirePreferences", ReplyAction="http://tempuri.org/IUserProfil/inquirePreferencesResponse")]
        string inquirePreferences(string[] args);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfil/inquirePreferences", ReplyAction="http://tempuri.org/IUserProfil/inquirePreferencesResponse")]
        System.Threading.Tasks.Task<string> inquirePreferencesAsync(string[] args);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfil/removePreferences", ReplyAction="http://tempuri.org/IUserProfil/removePreferencesResponse")]
        string removePreferences(string[] args);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfil/removePreferences", ReplyAction="http://tempuri.org/IUserProfil/removePreferencesResponse")]
        System.Threading.Tasks.Task<string> removePreferencesAsync(string[] args);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfil/inquireAllergies", ReplyAction="http://tempuri.org/IUserProfil/inquireAllergiesResponse")]
        string inquireAllergies(string[] args);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfil/inquireAllergies", ReplyAction="http://tempuri.org/IUserProfil/inquireAllergiesResponse")]
        System.Threading.Tasks.Task<string> inquireAllergiesAsync(string[] args);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfil/removeAllergies", ReplyAction="http://tempuri.org/IUserProfil/removeAllergiesResponse")]
        string removeAllergies(string[] args);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfil/removeAllergies", ReplyAction="http://tempuri.org/IUserProfil/removeAllergiesResponse")]
        System.Threading.Tasks.Task<string> removeAllergiesAsync(string[] args);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfil/emptyFridge", ReplyAction="http://tempuri.org/IUserProfil/emptyFridgeResponse")]
        string emptyFridge(string[] args);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfil/emptyFridge", ReplyAction="http://tempuri.org/IUserProfil/emptyFridgeResponse")]
        System.Threading.Tasks.Task<string> emptyFridgeAsync(string[] args);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserProfilChannel : Client.ServiceReference2.IUserProfil, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserProfilClient : System.ServiceModel.ClientBase<Client.ServiceReference2.IUserProfil>, Client.ServiceReference2.IUserProfil {
        
        public UserProfilClient() {
        }
        
        public UserProfilClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserProfilClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserProfilClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserProfilClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string addToFridge(string[] args) {
            return base.Channel.addToFridge(args);
        }
        
        public System.Threading.Tasks.Task<string> addToFridgeAsync(string[] args) {
            return base.Channel.addToFridgeAsync(args);
        }
        
        public string removeFromFridge(string[] args) {
            return base.Channel.removeFromFridge(args);
        }
        
        public System.Threading.Tasks.Task<string> removeFromFridgeAsync(string[] args) {
            return base.Channel.removeFromFridgeAsync(args);
        }
        
        public string inquirePreferences(string[] args) {
            return base.Channel.inquirePreferences(args);
        }
        
        public System.Threading.Tasks.Task<string> inquirePreferencesAsync(string[] args) {
            return base.Channel.inquirePreferencesAsync(args);
        }
        
        public string removePreferences(string[] args) {
            return base.Channel.removePreferences(args);
        }
        
        public System.Threading.Tasks.Task<string> removePreferencesAsync(string[] args) {
            return base.Channel.removePreferencesAsync(args);
        }
        
        public string inquireAllergies(string[] args) {
            return base.Channel.inquireAllergies(args);
        }
        
        public System.Threading.Tasks.Task<string> inquireAllergiesAsync(string[] args) {
            return base.Channel.inquireAllergiesAsync(args);
        }
        
        public string removeAllergies(string[] args) {
            return base.Channel.removeAllergies(args);
        }
        
        public System.Threading.Tasks.Task<string> removeAllergiesAsync(string[] args) {
            return base.Channel.removeAllergiesAsync(args);
        }
        
        public string emptyFridge(string[] args) {
            return base.Channel.emptyFridge(args);
        }
        
        public System.Threading.Tasks.Task<string> emptyFridgeAsync(string[] args) {
            return base.Channel.emptyFridgeAsync(args);
        }
    }
}
