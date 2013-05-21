﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SendRequestConsole.EAIOrchestration {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EAIOrchestration.EAIOrchestration_EAIProcess_ReceivePort")]
    public interface EAIOrchestration_EAIProcess_ReceivePort {
        
        // CODEGEN: Generating message contract since the operation Operation_1 is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="Operation_1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SendRequestConsole.EAIOrchestration.Operation_1Response Operation_1(SendRequestConsole.EAIOrchestration.Operation_1Request request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://EAISchemas.Request")]
    public partial class Request : object, System.ComponentModel.INotifyPropertyChanged {
        
        private RequestHeader headerField;
        
        private RequestItem[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public RequestHeader Header {
            get {
                return this.headerField;
            }
            set {
                this.headerField = value;
                this.RaisePropertyChanged("Header");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public RequestItem[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
                this.RaisePropertyChanged("Items");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://EAISchemas.Request")]
    public partial class RequestHeader : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string requestIDField;
        
        private System.DateTime orderDateField;
        
        private decimal grandTotalField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string RequestID {
            get {
                return this.requestIDField;
            }
            set {
                this.requestIDField = value;
                this.RaisePropertyChanged("RequestID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=1)]
        public System.DateTime OrderDate {
            get {
                return this.orderDateField;
            }
            set {
                this.orderDateField = value;
                this.RaisePropertyChanged("OrderDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public decimal GrandTotal {
            get {
                return this.grandTotalField;
            }
            set {
                this.grandTotalField = value;
                this.RaisePropertyChanged("GrandTotal");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://EAISchemas.Request")]
    public partial class RequestItem : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string descriptionField;
        
        private uint unitPriceField;
        
        private uint quantityField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
                this.RaisePropertyChanged("Description");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public uint UnitPrice {
            get {
                return this.unitPriceField;
            }
            set {
                this.unitPriceField = value;
                this.RaisePropertyChanged("UnitPrice");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public uint Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
                this.RaisePropertyChanged("Quantity");
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
    public partial class Operation_1Request {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://EAISchemas.Request", Order=0)]
        public SendRequestConsole.EAIOrchestration.Request Request;
        
        public Operation_1Request() {
        }
        
        public Operation_1Request(SendRequestConsole.EAIOrchestration.Request Request) {
            this.Request = Request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Operation_1Response {
        
        public Operation_1Response() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface EAIOrchestration_EAIProcess_ReceivePortChannel : SendRequestConsole.EAIOrchestration.EAIOrchestration_EAIProcess_ReceivePort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EAIOrchestration_EAIProcess_ReceivePortClient : System.ServiceModel.ClientBase<SendRequestConsole.EAIOrchestration.EAIOrchestration_EAIProcess_ReceivePort>, SendRequestConsole.EAIOrchestration.EAIOrchestration_EAIProcess_ReceivePort {
        
        public EAIOrchestration_EAIProcess_ReceivePortClient() {
        }
        
        public EAIOrchestration_EAIProcess_ReceivePortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EAIOrchestration_EAIProcess_ReceivePortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EAIOrchestration_EAIProcess_ReceivePortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EAIOrchestration_EAIProcess_ReceivePortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SendRequestConsole.EAIOrchestration.Operation_1Response SendRequestConsole.EAIOrchestration.EAIOrchestration_EAIProcess_ReceivePort.Operation_1(SendRequestConsole.EAIOrchestration.Operation_1Request request) {
            return base.Channel.Operation_1(request);
        }
        
        public void Operation_1(SendRequestConsole.EAIOrchestration.Request Request) {
            SendRequestConsole.EAIOrchestration.Operation_1Request inValue = new SendRequestConsole.EAIOrchestration.Operation_1Request();
            inValue.Request = Request;
            SendRequestConsole.EAIOrchestration.Operation_1Response retVal = ((SendRequestConsole.EAIOrchestration.EAIOrchestration_EAIProcess_ReceivePort)(this)).Operation_1(inValue);
        }
    }
}
