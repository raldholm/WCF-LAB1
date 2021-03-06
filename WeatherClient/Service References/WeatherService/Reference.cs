﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeatherClient.WeatherService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WeatherService.WeatherServiceSoap")]
    public interface WeatherServiceSoap {
        
        // CODEGEN: Generating message contract since element name WeatherResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Weather", ReplyAction="*")]
        WeatherClient.WeatherService.WeatherResponse Weather(WeatherClient.WeatherService.WeatherRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Weather", ReplyAction="*")]
        System.Threading.Tasks.Task<WeatherClient.WeatherService.WeatherResponse> WeatherAsync(WeatherClient.WeatherService.WeatherRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class WeatherRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Weather", Namespace="http://tempuri.org/", Order=0)]
        public WeatherClient.WeatherService.WeatherRequestBody Body;
        
        public WeatherRequest() {
        }
        
        public WeatherRequest(WeatherClient.WeatherService.WeatherRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class WeatherRequestBody {
        
        public WeatherRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class WeatherResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WeatherResponse", Namespace="http://tempuri.org/", Order=0)]
        public WeatherClient.WeatherService.WeatherResponseBody Body;
        
        public WeatherResponse() {
        }
        
        public WeatherResponse(WeatherClient.WeatherService.WeatherResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class WeatherResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string WeatherResult;
        
        public WeatherResponseBody() {
        }
        
        public WeatherResponseBody(string WeatherResult) {
            this.WeatherResult = WeatherResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WeatherServiceSoapChannel : WeatherClient.WeatherService.WeatherServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WeatherServiceSoapClient : System.ServiceModel.ClientBase<WeatherClient.WeatherService.WeatherServiceSoap>, WeatherClient.WeatherService.WeatherServiceSoap {
        
        public WeatherServiceSoapClient() {
        }
        
        public WeatherServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WeatherServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WeatherServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WeatherServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WeatherClient.WeatherService.WeatherResponse WeatherClient.WeatherService.WeatherServiceSoap.Weather(WeatherClient.WeatherService.WeatherRequest request) {
            return base.Channel.Weather(request);
        }
        
        public string Weather() {
            WeatherClient.WeatherService.WeatherRequest inValue = new WeatherClient.WeatherService.WeatherRequest();
            inValue.Body = new WeatherClient.WeatherService.WeatherRequestBody();
            WeatherClient.WeatherService.WeatherResponse retVal = ((WeatherClient.WeatherService.WeatherServiceSoap)(this)).Weather(inValue);
            return retVal.Body.WeatherResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WeatherClient.WeatherService.WeatherResponse> WeatherClient.WeatherService.WeatherServiceSoap.WeatherAsync(WeatherClient.WeatherService.WeatherRequest request) {
            return base.Channel.WeatherAsync(request);
        }
        
        public System.Threading.Tasks.Task<WeatherClient.WeatherService.WeatherResponse> WeatherAsync() {
            WeatherClient.WeatherService.WeatherRequest inValue = new WeatherClient.WeatherService.WeatherRequest();
            inValue.Body = new WeatherClient.WeatherService.WeatherRequestBody();
            return ((WeatherClient.WeatherService.WeatherServiceSoap)(this)).WeatherAsync(inValue);
        }
    }
}
