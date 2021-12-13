﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SE1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Eleve", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceEleve")]
    public partial class Eleve : object
    {
        
        private string CNEField;
        
        private string EmailField;
        
        private int IdField;
        
        private string NomField;
        
        private string PhotoField;
        
        private string PrenomField;
        
        private string TelField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CNE
        {
            get
            {
                return this.CNEField;
            }
            set
            {
                this.CNEField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom
        {
            get
            {
                return this.NomField;
            }
            set
            {
                this.NomField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Photo
        {
            get
            {
                return this.PhotoField;
            }
            set
            {
                this.PhotoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Prenom
        {
            get
            {
                return this.PrenomField;
            }
            set
            {
                this.PrenomField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tel
        {
            get
            {
                return this.TelField;
            }
            set
            {
                this.TelField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SE1.IEleveService")]
    public interface IEleveService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEleveService/findAll", ReplyAction="http://tempuri.org/IEleveService/findAllResponse")]
        SE1.Eleve[] findAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEleveService/findAll", ReplyAction="http://tempuri.org/IEleveService/findAllResponse")]
        System.Threading.Tasks.Task<SE1.Eleve[]> findAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEleveService/findByCNE", ReplyAction="http://tempuri.org/IEleveService/findByCNEResponse")]
        SE1.Eleve[] findByCNE(string CNE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEleveService/findByCNE", ReplyAction="http://tempuri.org/IEleveService/findByCNEResponse")]
        System.Threading.Tasks.Task<SE1.Eleve[]> findByCNEAsync(string CNE);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    public interface IEleveServiceChannel : SE1.IEleveService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    public partial class EleveServiceClient : System.ServiceModel.ClientBase<SE1.IEleveService>, SE1.IEleveService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public EleveServiceClient() : 
                base(EleveServiceClient.GetDefaultBinding(), EleveServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IEleveService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public EleveServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(EleveServiceClient.GetBindingForEndpoint(endpointConfiguration), EleveServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public EleveServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(EleveServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public EleveServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(EleveServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public EleveServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public SE1.Eleve[] findAll()
        {
            return base.Channel.findAll();
        }
        
        public System.Threading.Tasks.Task<SE1.Eleve[]> findAllAsync()
        {
            return base.Channel.findAllAsync();
        }
        
        public SE1.Eleve[] findByCNE(string CNE)
        {
            return base.Channel.findByCNE(CNE);
        }
        
        public System.Threading.Tasks.Task<SE1.Eleve[]> findByCNEAsync(string CNE)
        {
            return base.Channel.findByCNEAsync(CNE);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IEleveService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IEleveService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:63422/EleveService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return EleveServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IEleveService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return EleveServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IEleveService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IEleveService,
        }
    }
}
