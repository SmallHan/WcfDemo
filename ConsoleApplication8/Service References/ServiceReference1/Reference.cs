﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication8.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IFlyService")]
    public interface IFlyService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IFlyService/DoBigAnalysisFast")]
        void DoBigAnalysisFast(string ticket);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IFlyService/DoBigAnalysisFast")]
        System.Threading.Tasks.Task DoBigAnalysisFastAsync(string ticket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlyService/DoBigAnalysisSlow", ReplyAction="http://tempuri.org/IFlyService/DoBigAnalysisSlowResponse")]
        void DoBigAnalysisSlow(string ticket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlyService/DoBigAnalysisSlow", ReplyAction="http://tempuri.org/IFlyService/DoBigAnalysisSlowResponse")]
        System.Threading.Tasks.Task DoBigAnalysisSlowAsync(string ticket);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFlyServiceChannel : ConsoleApplication8.ServiceReference1.IFlyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FlyServiceClient : System.ServiceModel.ClientBase<ConsoleApplication8.ServiceReference1.IFlyService>, ConsoleApplication8.ServiceReference1.IFlyService {
        
        public FlyServiceClient() {
        }
        
        public FlyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FlyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FlyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FlyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoBigAnalysisFast(string ticket) {
            base.Channel.DoBigAnalysisFast(ticket);
        }
        
        public System.Threading.Tasks.Task DoBigAnalysisFastAsync(string ticket) {
            return base.Channel.DoBigAnalysisFastAsync(ticket);
        }
        
        public void DoBigAnalysisSlow(string ticket) {
            base.Channel.DoBigAnalysisSlow(ticket);
        }
        
        public System.Threading.Tasks.Task DoBigAnalysisSlowAsync(string ticket) {
            return base.Channel.DoBigAnalysisSlowAsync(ticket);
        }
    }
}
