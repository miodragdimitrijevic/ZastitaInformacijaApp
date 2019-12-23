﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckUser", ReplyAction="http://tempuri.org/IService1/CheckUserResponse")]
        bool CheckUser(string ime, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckUser", ReplyAction="http://tempuri.org/IService1/CheckUserResponse")]
        System.Threading.Tasks.Task<bool> CheckUserAsync(string ime, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetIdUser", ReplyAction="http://tempuri.org/IService1/GetIdUserResponse")]
        int GetIdUser(string ime, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetIdUser", ReplyAction="http://tempuri.org/IService1/GetIdUserResponse")]
        System.Threading.Tasks.Task<int> GetIdUserAsync(string ime, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/insertInFiles", ReplyAction="http://tempuri.org/IService1/insertInFilesResponse")]
        void insertInFiles(string bajtoviFajla, string metoda, string hashkod, int idKorisnik, string naziv, string textfajla);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/insertInFiles", ReplyAction="http://tempuri.org/IService1/insertInFilesResponse")]
        System.Threading.Tasks.Task insertInFilesAsync(string bajtoviFajla, string metoda, string hashkod, int idKorisnik, string naziv, string textfajla);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getUserFiles", ReplyAction="http://tempuri.org/IService1/getUserFilesResponse")]
        string[] getUserFiles(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getUserFiles", ReplyAction="http://tempuri.org/IService1/getUserFilesResponse")]
        System.Threading.Tasks.Task<string[]> getUserFilesAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getUserFile", ReplyAction="http://tempuri.org/IService1/getUserFileResponse")]
        string getUserFile(int userId, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getUserFile", ReplyAction="http://tempuri.org/IService1/getUserFileResponse")]
        System.Threading.Tasks.Task<string> getUserFileAsync(int userId, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetFileText", ReplyAction="http://tempuri.org/IService1/GetFileTextResponse")]
        string GetFileText(int id, string imeFajla);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetFileText", ReplyAction="http://tempuri.org/IService1/GetFileTextResponse")]
        System.Threading.Tasks.Task<string> GetFileTextAsync(int id, string imeFajla);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMethod", ReplyAction="http://tempuri.org/IService1/GetMethodResponse")]
        string GetMethod(int id, string imeFajla);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMethod", ReplyAction="http://tempuri.org/IService1/GetMethodResponse")]
        System.Threading.Tasks.Task<string> GetMethodAsync(int id, string imeFajla);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WindowsFormClient.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WindowsFormClient.ServiceReference1.IService1>, WindowsFormClient.ServiceReference1.IService1 {
        
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
        
        public bool CheckUser(string ime, string pass) {
            return base.Channel.CheckUser(ime, pass);
        }
        
        public System.Threading.Tasks.Task<bool> CheckUserAsync(string ime, string pass) {
            return base.Channel.CheckUserAsync(ime, pass);
        }
        
        public int GetIdUser(string ime, string pass) {
            return base.Channel.GetIdUser(ime, pass);
        }
        
        public System.Threading.Tasks.Task<int> GetIdUserAsync(string ime, string pass) {
            return base.Channel.GetIdUserAsync(ime, pass);
        }
        
        public void insertInFiles(string bajtoviFajla, string metoda, string hashkod, int idKorisnik, string naziv, string textfajla) {
            base.Channel.insertInFiles(bajtoviFajla, metoda, hashkod, idKorisnik, naziv, textfajla);
        }
        
        public System.Threading.Tasks.Task insertInFilesAsync(string bajtoviFajla, string metoda, string hashkod, int idKorisnik, string naziv, string textfajla) {
            return base.Channel.insertInFilesAsync(bajtoviFajla, metoda, hashkod, idKorisnik, naziv, textfajla);
        }
        
        public string[] getUserFiles(int userId) {
            return base.Channel.getUserFiles(userId);
        }
        
        public System.Threading.Tasks.Task<string[]> getUserFilesAsync(int userId) {
            return base.Channel.getUserFilesAsync(userId);
        }
        
        public string getUserFile(int userId, string name) {
            return base.Channel.getUserFile(userId, name);
        }
        
        public System.Threading.Tasks.Task<string> getUserFileAsync(int userId, string name) {
            return base.Channel.getUserFileAsync(userId, name);
        }
        
        public string GetFileText(int id, string imeFajla) {
            return base.Channel.GetFileText(id, imeFajla);
        }
        
        public System.Threading.Tasks.Task<string> GetFileTextAsync(int id, string imeFajla) {
            return base.Channel.GetFileTextAsync(id, imeFajla);
        }
        
        public string GetMethod(int id, string imeFajla) {
            return base.Channel.GetMethod(id, imeFajla);
        }
        
        public System.Threading.Tasks.Task<string> GetMethodAsync(int id, string imeFajla) {
            return base.Channel.GetMethodAsync(id, imeFajla);
        }
    }
}
