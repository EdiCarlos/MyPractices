﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestManagerClient.TestManagerServiceClient {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TestManagerServiceClient.ITestManagerService")]
    public interface ITestManagerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestManagerService/GetTest", ReplyAction="http://tempuri.org/ITestManagerService/GetTestResponse")]
        TestManagerslib.Contract.CTestManager GetTest(int TestID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestManagerService/GetTest", ReplyAction="http://tempuri.org/ITestManagerService/GetTestResponse")]
        System.Threading.Tasks.Task<TestManagerslib.Contract.CTestManager> GetTestAsync(int TestID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestManagerService/GetTests", ReplyAction="http://tempuri.org/ITestManagerService/GetTestsResponse")]
        System.Collections.Generic.List<TestManagerslib.Contract.CTestManager> GetTests(System.Collections.Generic.List<int> TestIds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestManagerService/GetTests", ReplyAction="http://tempuri.org/ITestManagerService/GetTestsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<TestManagerslib.Contract.CTestManager>> GetTestsAsync(System.Collections.Generic.List<int> TestIds);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ITestManagerService/InsertTest")]
        void InsertTest(TestManagerslib.Contract.CTestManager manager);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ITestManagerService/InsertTest")]
        System.Threading.Tasks.Task InsertTestAsync(TestManagerslib.Contract.CTestManager manager);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestManagerService/GetClaims", ReplyAction="http://tempuri.org/ITestManagerService/GetClaimsResponse")]
        System.Collections.Generic.List<string> GetClaims();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestManagerService/GetClaims", ReplyAction="http://tempuri.org/ITestManagerService/GetClaimsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> GetClaimsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITestManagerServiceChannel : TestManagerClient.TestManagerServiceClient.ITestManagerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TestManagerServiceClient : System.ServiceModel.ClientBase<TestManagerClient.TestManagerServiceClient.ITestManagerService>, TestManagerClient.TestManagerServiceClient.ITestManagerService {
        
        public TestManagerServiceClient() {
        }
        
        public TestManagerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TestManagerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TestManagerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TestManagerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TestManagerslib.Contract.CTestManager GetTest(int TestID) {
            return base.Channel.GetTest(TestID);
        }
        
        public System.Threading.Tasks.Task<TestManagerslib.Contract.CTestManager> GetTestAsync(int TestID) {
            return base.Channel.GetTestAsync(TestID);
        }
        
        public System.Collections.Generic.List<TestManagerslib.Contract.CTestManager> GetTests(System.Collections.Generic.List<int> TestIds) {
            return base.Channel.GetTests(TestIds);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<TestManagerslib.Contract.CTestManager>> GetTestsAsync(System.Collections.Generic.List<int> TestIds) {
            return base.Channel.GetTestsAsync(TestIds);
        }
        
        public void InsertTest(TestManagerslib.Contract.CTestManager manager) {
            base.Channel.InsertTest(manager);
        }
        
        public System.Threading.Tasks.Task InsertTestAsync(TestManagerslib.Contract.CTestManager manager) {
            return base.Channel.InsertTestAsync(manager);
        }
        
        public System.Collections.Generic.List<string> GetClaims() {
            return base.Channel.GetClaims();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<string>> GetClaimsAsync() {
            return base.Channel.GetClaimsAsync();
        }
    }
}
