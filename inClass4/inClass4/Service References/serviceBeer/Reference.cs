﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace inClass4.serviceBeer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://server/", ConfigurationName="serviceBeer.Beer")]
    public interface Beer {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://server/Beer/getMethodsRequest", ReplyAction="http://server/Beer/getMethodsResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        inClass4.serviceBeer.getMethodsResponse getMethods(inClass4.serviceBeer.getMethodsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://server/Beer/getMethodsRequest", ReplyAction="http://server/Beer/getMethodsResponse")]
        System.Threading.Tasks.Task<inClass4.serviceBeer.getMethodsResponse> getMethodsAsync(inClass4.serviceBeer.getMethodsRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://server/Beer/HelloWorldRequest", ReplyAction="http://server/Beer/HelloWorldResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        inClass4.serviceBeer.HelloWorldResponse HelloWorld(inClass4.serviceBeer.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://server/Beer/HelloWorldRequest", ReplyAction="http://server/Beer/HelloWorldResponse")]
        System.Threading.Tasks.Task<inClass4.serviceBeer.HelloWorldResponse> HelloWorldAsync(inClass4.serviceBeer.HelloWorldRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://server/Beer/getCheapestRequest", ReplyAction="http://server/Beer/getCheapestResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        inClass4.serviceBeer.getCheapestResponse getCheapest(inClass4.serviceBeer.getCheapestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://server/Beer/getCheapestRequest", ReplyAction="http://server/Beer/getCheapestResponse")]
        System.Threading.Tasks.Task<inClass4.serviceBeer.getCheapestResponse> getCheapestAsync(inClass4.serviceBeer.getCheapestRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://server/Beer/getCostliestRequest", ReplyAction="http://server/Beer/getCostliestResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        inClass4.serviceBeer.getCostliestResponse getCostliest(inClass4.serviceBeer.getCostliestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://server/Beer/getCostliestRequest", ReplyAction="http://server/Beer/getCostliestResponse")]
        System.Threading.Tasks.Task<inClass4.serviceBeer.getCostliestResponse> getCostliestAsync(inClass4.serviceBeer.getCostliestRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://server/Beer/getPriceRequest", ReplyAction="http://server/Beer/getPriceResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        inClass4.serviceBeer.getPriceResponse getPrice(inClass4.serviceBeer.getPriceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://server/Beer/getPriceRequest", ReplyAction="http://server/Beer/getPriceResponse")]
        System.Threading.Tasks.Task<inClass4.serviceBeer.getPriceResponse> getPriceAsync(inClass4.serviceBeer.getPriceRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://server/Beer/getBeersRequest", ReplyAction="http://server/Beer/getBeersResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        inClass4.serviceBeer.getBeersResponse getBeers(inClass4.serviceBeer.getBeersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://server/Beer/getBeersRequest", ReplyAction="http://server/Beer/getBeersResponse")]
        System.Threading.Tasks.Task<inClass4.serviceBeer.getBeersResponse> getBeersAsync(inClass4.serviceBeer.getBeersRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getMethods", WrapperNamespace="http://server/", IsWrapped=true)]
    public partial class getMethodsRequest {
        
        public getMethodsRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getMethodsResponse", WrapperNamespace="http://server/", IsWrapped=true)]
    public partial class getMethodsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://server/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string[] @return;
        
        public getMethodsResponse() {
        }
        
        public getMethodsResponse(string[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="HelloWorld", WrapperNamespace="http://server/", IsWrapped=true)]
    public partial class HelloWorldRequest {
        
        public HelloWorldRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="HelloWorldResponse", WrapperNamespace="http://server/", IsWrapped=true)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://server/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCheapest", WrapperNamespace="http://server/", IsWrapped=true)]
    public partial class getCheapestRequest {
        
        public getCheapestRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCheapestResponse", WrapperNamespace="http://server/", IsWrapped=true)]
    public partial class getCheapestResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://server/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public getCheapestResponse() {
        }
        
        public getCheapestResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCostliest", WrapperNamespace="http://server/", IsWrapped=true)]
    public partial class getCostliestRequest {
        
        public getCostliestRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCostliestResponse", WrapperNamespace="http://server/", IsWrapped=true)]
    public partial class getCostliestResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://server/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public getCostliestResponse() {
        }
        
        public getCostliestResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getPrice", WrapperNamespace="http://server/", IsWrapped=true)]
    public partial class getPriceRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://server/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;
        
        public getPriceRequest() {
        }
        
        public getPriceRequest(string arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getPriceResponse", WrapperNamespace="http://server/", IsWrapped=true)]
    public partial class getPriceResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://server/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double @return;
        
        public getPriceResponse() {
        }
        
        public getPriceResponse(double @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getBeers", WrapperNamespace="http://server/", IsWrapped=true)]
    public partial class getBeersRequest {
        
        public getBeersRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getBeersResponse", WrapperNamespace="http://server/", IsWrapped=true)]
    public partial class getBeersResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://server/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string[] @return;
        
        public getBeersResponse() {
        }
        
        public getBeersResponse(string[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BeerChannel : inClass4.serviceBeer.Beer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BeerClient : System.ServiceModel.ClientBase<inClass4.serviceBeer.Beer>, inClass4.serviceBeer.Beer {
        
        public BeerClient() {
        }
        
        public BeerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BeerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BeerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BeerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        inClass4.serviceBeer.getMethodsResponse inClass4.serviceBeer.Beer.getMethods(inClass4.serviceBeer.getMethodsRequest request) {
            return base.Channel.getMethods(request);
        }
        
        public string[] getMethods() {
            inClass4.serviceBeer.getMethodsRequest inValue = new inClass4.serviceBeer.getMethodsRequest();
            inClass4.serviceBeer.getMethodsResponse retVal = ((inClass4.serviceBeer.Beer)(this)).getMethods(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<inClass4.serviceBeer.getMethodsResponse> inClass4.serviceBeer.Beer.getMethodsAsync(inClass4.serviceBeer.getMethodsRequest request) {
            return base.Channel.getMethodsAsync(request);
        }
        
        public System.Threading.Tasks.Task<inClass4.serviceBeer.getMethodsResponse> getMethodsAsync() {
            inClass4.serviceBeer.getMethodsRequest inValue = new inClass4.serviceBeer.getMethodsRequest();
            return ((inClass4.serviceBeer.Beer)(this)).getMethodsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        inClass4.serviceBeer.HelloWorldResponse inClass4.serviceBeer.Beer.HelloWorld(inClass4.serviceBeer.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            inClass4.serviceBeer.HelloWorldRequest inValue = new inClass4.serviceBeer.HelloWorldRequest();
            inClass4.serviceBeer.HelloWorldResponse retVal = ((inClass4.serviceBeer.Beer)(this)).HelloWorld(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<inClass4.serviceBeer.HelloWorldResponse> inClass4.serviceBeer.Beer.HelloWorldAsync(inClass4.serviceBeer.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<inClass4.serviceBeer.HelloWorldResponse> HelloWorldAsync() {
            inClass4.serviceBeer.HelloWorldRequest inValue = new inClass4.serviceBeer.HelloWorldRequest();
            return ((inClass4.serviceBeer.Beer)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        inClass4.serviceBeer.getCheapestResponse inClass4.serviceBeer.Beer.getCheapest(inClass4.serviceBeer.getCheapestRequest request) {
            return base.Channel.getCheapest(request);
        }
        
        public string getCheapest() {
            inClass4.serviceBeer.getCheapestRequest inValue = new inClass4.serviceBeer.getCheapestRequest();
            inClass4.serviceBeer.getCheapestResponse retVal = ((inClass4.serviceBeer.Beer)(this)).getCheapest(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<inClass4.serviceBeer.getCheapestResponse> inClass4.serviceBeer.Beer.getCheapestAsync(inClass4.serviceBeer.getCheapestRequest request) {
            return base.Channel.getCheapestAsync(request);
        }
        
        public System.Threading.Tasks.Task<inClass4.serviceBeer.getCheapestResponse> getCheapestAsync() {
            inClass4.serviceBeer.getCheapestRequest inValue = new inClass4.serviceBeer.getCheapestRequest();
            return ((inClass4.serviceBeer.Beer)(this)).getCheapestAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        inClass4.serviceBeer.getCostliestResponse inClass4.serviceBeer.Beer.getCostliest(inClass4.serviceBeer.getCostliestRequest request) {
            return base.Channel.getCostliest(request);
        }
        
        public string getCostliest() {
            inClass4.serviceBeer.getCostliestRequest inValue = new inClass4.serviceBeer.getCostliestRequest();
            inClass4.serviceBeer.getCostliestResponse retVal = ((inClass4.serviceBeer.Beer)(this)).getCostliest(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<inClass4.serviceBeer.getCostliestResponse> inClass4.serviceBeer.Beer.getCostliestAsync(inClass4.serviceBeer.getCostliestRequest request) {
            return base.Channel.getCostliestAsync(request);
        }
        
        public System.Threading.Tasks.Task<inClass4.serviceBeer.getCostliestResponse> getCostliestAsync() {
            inClass4.serviceBeer.getCostliestRequest inValue = new inClass4.serviceBeer.getCostliestRequest();
            return ((inClass4.serviceBeer.Beer)(this)).getCostliestAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        inClass4.serviceBeer.getPriceResponse inClass4.serviceBeer.Beer.getPrice(inClass4.serviceBeer.getPriceRequest request) {
            return base.Channel.getPrice(request);
        }
        
        public double getPrice(string arg0) {
            inClass4.serviceBeer.getPriceRequest inValue = new inClass4.serviceBeer.getPriceRequest();
            inValue.arg0 = arg0;
            inClass4.serviceBeer.getPriceResponse retVal = ((inClass4.serviceBeer.Beer)(this)).getPrice(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<inClass4.serviceBeer.getPriceResponse> inClass4.serviceBeer.Beer.getPriceAsync(inClass4.serviceBeer.getPriceRequest request) {
            return base.Channel.getPriceAsync(request);
        }
        
        public System.Threading.Tasks.Task<inClass4.serviceBeer.getPriceResponse> getPriceAsync(string arg0) {
            inClass4.serviceBeer.getPriceRequest inValue = new inClass4.serviceBeer.getPriceRequest();
            inValue.arg0 = arg0;
            return ((inClass4.serviceBeer.Beer)(this)).getPriceAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        inClass4.serviceBeer.getBeersResponse inClass4.serviceBeer.Beer.getBeers(inClass4.serviceBeer.getBeersRequest request) {
            return base.Channel.getBeers(request);
        }
        
        public string[] getBeers() {
            inClass4.serviceBeer.getBeersRequest inValue = new inClass4.serviceBeer.getBeersRequest();
            inClass4.serviceBeer.getBeersResponse retVal = ((inClass4.serviceBeer.Beer)(this)).getBeers(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<inClass4.serviceBeer.getBeersResponse> inClass4.serviceBeer.Beer.getBeersAsync(inClass4.serviceBeer.getBeersRequest request) {
            return base.Channel.getBeersAsync(request);
        }
        
        public System.Threading.Tasks.Task<inClass4.serviceBeer.getBeersResponse> getBeersAsync() {
            inClass4.serviceBeer.getBeersRequest inValue = new inClass4.serviceBeer.getBeersRequest();
            return ((inClass4.serviceBeer.Beer)(this)).getBeersAsync(inValue);
        }
    }
}
