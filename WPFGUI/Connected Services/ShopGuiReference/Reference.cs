﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFGUI.ShopGuiReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/ShopServerLibrary")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
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
        public int Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/ShopServerLibrary")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double BalanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WPFGUI.ShopGuiReference.Product[] BoughtProductsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        public double Balance {
            get {
                return this.BalanceField;
            }
            set {
                if ((this.BalanceField.Equals(value) != true)) {
                    this.BalanceField = value;
                    this.RaisePropertyChanged("Balance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WPFGUI.ShopGuiReference.Product[] BoughtProducts {
            get {
                return this.BoughtProductsField;
            }
            set {
                if ((object.ReferenceEquals(this.BoughtProductsField, value) != true)) {
                    this.BoughtProductsField = value;
                    this.RaisePropertyChanged("BoughtProducts");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ShopGuiReference.IShopService")]
    public interface IShopService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopService/PostNote", ReplyAction="http://tempuri.org/IShopService/PostNoteResponse")]
        void PostNote(string from, string note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopService/PostNote", ReplyAction="http://tempuri.org/IShopService/PostNoteResponse")]
        System.Threading.Tasks.Task PostNoteAsync(string from, string note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopService/GetAllProducts", ReplyAction="http://tempuri.org/IShopService/GetAllProductsResponse")]
        WPFGUI.ShopGuiReference.Product[] GetAllProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopService/GetAllProducts", ReplyAction="http://tempuri.org/IShopService/GetAllProductsResponse")]
        System.Threading.Tasks.Task<WPFGUI.ShopGuiReference.Product[]> GetAllProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopService/BuyProduct", ReplyAction="http://tempuri.org/IShopService/BuyProductResponse")]
        string BuyProduct(WPFGUI.ShopGuiReference.User u, WPFGUI.ShopGuiReference.Product p, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopService/BuyProduct", ReplyAction="http://tempuri.org/IShopService/BuyProductResponse")]
        System.Threading.Tasks.Task<string> BuyProductAsync(WPFGUI.ShopGuiReference.User u, WPFGUI.ShopGuiReference.Product p, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopService/Login", ReplyAction="http://tempuri.org/IShopService/LoginResponse")]
        string Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopService/Login", ReplyAction="http://tempuri.org/IShopService/LoginResponse")]
        System.Threading.Tasks.Task<string> LoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopService/Register", ReplyAction="http://tempuri.org/IShopService/RegisterResponse")]
        string Register(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopService/Register", ReplyAction="http://tempuri.org/IShopService/RegisterResponse")]
        System.Threading.Tasks.Task<string> RegisterAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopService/GetBoughtProducts", ReplyAction="http://tempuri.org/IShopService/GetBoughtProductsResponse")]
        WPFGUI.ShopGuiReference.Product[] GetBoughtProducts(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopService/GetBoughtProducts", ReplyAction="http://tempuri.org/IShopService/GetBoughtProductsResponse")]
        System.Threading.Tasks.Task<WPFGUI.ShopGuiReference.Product[]> GetBoughtProductsAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IShopServiceChannel : WPFGUI.ShopGuiReference.IShopService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ShopServiceClient : System.ServiceModel.ClientBase<WPFGUI.ShopGuiReference.IShopService>, WPFGUI.ShopGuiReference.IShopService {
        
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
        
        public WPFGUI.ShopGuiReference.Product[] GetAllProducts() {
            return base.Channel.GetAllProducts();
        }
        
        public System.Threading.Tasks.Task<WPFGUI.ShopGuiReference.Product[]> GetAllProductsAsync() {
            return base.Channel.GetAllProductsAsync();
        }
        
        public string BuyProduct(WPFGUI.ShopGuiReference.User u, WPFGUI.ShopGuiReference.Product p, int amount) {
            return base.Channel.BuyProduct(u, p, amount);
        }
        
        public System.Threading.Tasks.Task<string> BuyProductAsync(WPFGUI.ShopGuiReference.User u, WPFGUI.ShopGuiReference.Product p, int amount) {
            return base.Channel.BuyProductAsync(u, p, amount);
        }
        
        public string Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Threading.Tasks.Task<string> LoginAsync(string username, string password) {
            return base.Channel.LoginAsync(username, password);
        }
        
        public string Register(string username) {
            return base.Channel.Register(username);
        }
        
        public System.Threading.Tasks.Task<string> RegisterAsync(string username) {
            return base.Channel.RegisterAsync(username);
        }
        
        public WPFGUI.ShopGuiReference.Product[] GetBoughtProducts(int id) {
            return base.Channel.GetBoughtProducts(id);
        }
        
        public System.Threading.Tasks.Task<WPFGUI.ShopGuiReference.Product[]> GetBoughtProductsAsync(int id) {
            return base.Channel.GetBoughtProductsAsync(id);
        }
    }
}