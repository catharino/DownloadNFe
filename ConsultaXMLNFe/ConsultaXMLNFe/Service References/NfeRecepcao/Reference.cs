﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsultaXMLNFe.NfeRecepcao {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.portalfiscal.inf.br/nfe/wsdl/RecepcaoEvento", ConfigurationName="NfeRecepcao.RecepcaoEventoSoap")]
    public interface RecepcaoEventoSoap {
        
        // CODEGEN: Generating message contract since the operation nfeRecepcaoEvento is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.portalfiscal.inf.br/nfe/wsdl/RecepcaoEvento/nfeRecepcaoEvento", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ConsultaXMLNFe.NfeRecepcao.nfeRecepcaoEventoResponse nfeRecepcaoEvento(ConsultaXMLNFe.NfeRecepcao.nfeRecepcaoEventoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.portalfiscal.inf.br/nfe/wsdl/RecepcaoEvento/nfeRecepcaoEvento", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsultaXMLNFe.NfeRecepcao.nfeRecepcaoEventoResponse> nfeRecepcaoEventoAsync(ConsultaXMLNFe.NfeRecepcao.nfeRecepcaoEventoRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/nfe/wsdl/RecepcaoEvento")]
    public partial class nfeCabecMsg : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string versaoDadosField;
        
        private string cUFField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string versaoDados {
            get {
                return this.versaoDadosField;
            }
            set {
                this.versaoDadosField = value;
                this.RaisePropertyChanged("versaoDados");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string cUF {
            get {
                return this.cUFField;
            }
            set {
                this.cUFField = value;
                this.RaisePropertyChanged("cUF");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class nfeRecepcaoEventoRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.portalfiscal.inf.br/nfe/wsdl/RecepcaoEvento")]
        public ConsultaXMLNFe.NfeRecepcao.nfeCabecMsg nfeCabecMsg;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.portalfiscal.inf.br/nfe/wsdl/RecepcaoEvento", Order=0)]
        public System.Xml.XmlNode nfeDadosMsg;
        
        public nfeRecepcaoEventoRequest() {
        }
        
        public nfeRecepcaoEventoRequest(ConsultaXMLNFe.NfeRecepcao.nfeCabecMsg nfeCabecMsg, System.Xml.XmlNode nfeDadosMsg) {
            this.nfeCabecMsg = nfeCabecMsg;
            this.nfeDadosMsg = nfeDadosMsg;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class nfeRecepcaoEventoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.portalfiscal.inf.br/nfe/wsdl/RecepcaoEvento", Order=0)]
        public System.Xml.XmlNode nfeRecepcaoEventoResult;
        
        public nfeRecepcaoEventoResponse() {
        }
        
        public nfeRecepcaoEventoResponse(System.Xml.XmlNode nfeRecepcaoEventoResult) {
            this.nfeRecepcaoEventoResult = nfeRecepcaoEventoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface RecepcaoEventoSoapChannel : ConsultaXMLNFe.NfeRecepcao.RecepcaoEventoSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RecepcaoEventoSoapClient : System.ServiceModel.ClientBase<ConsultaXMLNFe.NfeRecepcao.RecepcaoEventoSoap>, ConsultaXMLNFe.NfeRecepcao.RecepcaoEventoSoap {
        
        public RecepcaoEventoSoapClient() {
        }
        
        public RecepcaoEventoSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RecepcaoEventoSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RecepcaoEventoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RecepcaoEventoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsultaXMLNFe.NfeRecepcao.nfeRecepcaoEventoResponse ConsultaXMLNFe.NfeRecepcao.RecepcaoEventoSoap.nfeRecepcaoEvento(ConsultaXMLNFe.NfeRecepcao.nfeRecepcaoEventoRequest request) {
            return base.Channel.nfeRecepcaoEvento(request);
        }
        
        public System.Xml.XmlNode nfeRecepcaoEvento(ConsultaXMLNFe.NfeRecepcao.nfeCabecMsg nfeCabecMsg, System.Xml.XmlNode nfeDadosMsg) {
            ConsultaXMLNFe.NfeRecepcao.nfeRecepcaoEventoRequest inValue = new ConsultaXMLNFe.NfeRecepcao.nfeRecepcaoEventoRequest();
            inValue.nfeCabecMsg = nfeCabecMsg;
            inValue.nfeDadosMsg = nfeDadosMsg;
            ConsultaXMLNFe.NfeRecepcao.nfeRecepcaoEventoResponse retVal = ((ConsultaXMLNFe.NfeRecepcao.RecepcaoEventoSoap)(this)).nfeRecepcaoEvento(inValue);
            return retVal.nfeRecepcaoEventoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsultaXMLNFe.NfeRecepcao.nfeRecepcaoEventoResponse> ConsultaXMLNFe.NfeRecepcao.RecepcaoEventoSoap.nfeRecepcaoEventoAsync(ConsultaXMLNFe.NfeRecepcao.nfeRecepcaoEventoRequest request) {
            return base.Channel.nfeRecepcaoEventoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsultaXMLNFe.NfeRecepcao.nfeRecepcaoEventoResponse> nfeRecepcaoEventoAsync(ConsultaXMLNFe.NfeRecepcao.nfeCabecMsg nfeCabecMsg, System.Xml.XmlNode nfeDadosMsg) {
            ConsultaXMLNFe.NfeRecepcao.nfeRecepcaoEventoRequest inValue = new ConsultaXMLNFe.NfeRecepcao.nfeRecepcaoEventoRequest();
            inValue.nfeCabecMsg = nfeCabecMsg;
            inValue.nfeDadosMsg = nfeDadosMsg;
            return ((ConsultaXMLNFe.NfeRecepcao.RecepcaoEventoSoap)(this)).nfeRecepcaoEventoAsync(inValue);
        }
    }
}