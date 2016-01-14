﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NameDayClient.NameDayService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NameDayService.NameDayServiceSoap")]
    public interface NameDayServiceSoap {
        
        // CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDateByName", ReplyAction="*")]
        NameDayClient.NameDayService.GetDateByNameResponse GetDateByName(NameDayClient.NameDayService.GetDateByNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDateByName", ReplyAction="*")]
        System.Threading.Tasks.Task<NameDayClient.NameDayService.GetDateByNameResponse> GetDateByNameAsync(NameDayClient.NameDayService.GetDateByNameRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDateByNameRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetDateByName", Namespace="http://tempuri.org/", Order=0)]
        public NameDayClient.NameDayService.GetDateByNameRequestBody Body;
        
        public GetDateByNameRequest() {
        }
        
        public GetDateByNameRequest(NameDayClient.NameDayService.GetDateByNameRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetDateByNameRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        public GetDateByNameRequestBody() {
        }
        
        public GetDateByNameRequestBody(string name) {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDateByNameResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetDateByNameResponse", Namespace="http://tempuri.org/", Order=0)]
        public NameDayClient.NameDayService.GetDateByNameResponseBody Body;
        
        public GetDateByNameResponse() {
        }
        
        public GetDateByNameResponse(NameDayClient.NameDayService.GetDateByNameResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetDateByNameResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public System.DateTime GetDateByNameResult;
        
        public GetDateByNameResponseBody() {
        }
        
        public GetDateByNameResponseBody(System.DateTime GetDateByNameResult) {
            this.GetDateByNameResult = GetDateByNameResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface NameDayServiceSoapChannel : NameDayClient.NameDayService.NameDayServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NameDayServiceSoapClient : System.ServiceModel.ClientBase<NameDayClient.NameDayService.NameDayServiceSoap>, NameDayClient.NameDayService.NameDayServiceSoap {
        
        public NameDayServiceSoapClient() {
        }
        
        public NameDayServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NameDayServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NameDayServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NameDayServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NameDayClient.NameDayService.GetDateByNameResponse NameDayClient.NameDayService.NameDayServiceSoap.GetDateByName(NameDayClient.NameDayService.GetDateByNameRequest request) {
            return base.Channel.GetDateByName(request);
        }
        
        public System.DateTime GetDateByName(string name) {
            NameDayClient.NameDayService.GetDateByNameRequest inValue = new NameDayClient.NameDayService.GetDateByNameRequest();
            inValue.Body = new NameDayClient.NameDayService.GetDateByNameRequestBody();
            inValue.Body.name = name;
            NameDayClient.NameDayService.GetDateByNameResponse retVal = ((NameDayClient.NameDayService.NameDayServiceSoap)(this)).GetDateByName(inValue);
            return retVal.Body.GetDateByNameResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NameDayClient.NameDayService.GetDateByNameResponse> NameDayClient.NameDayService.NameDayServiceSoap.GetDateByNameAsync(NameDayClient.NameDayService.GetDateByNameRequest request) {
            return base.Channel.GetDateByNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<NameDayClient.NameDayService.GetDateByNameResponse> GetDateByNameAsync(string name) {
            NameDayClient.NameDayService.GetDateByNameRequest inValue = new NameDayClient.NameDayService.GetDateByNameRequest();
            inValue.Body = new NameDayClient.NameDayService.GetDateByNameRequestBody();
            inValue.Body.name = name;
            return ((NameDayClient.NameDayService.NameDayServiceSoap)(this)).GetDateByNameAsync(inValue);
        }
    }
}