﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://calculatorService", ConfigurationName="ICalculatorService", CallbackContract=typeof(ICalculatorServiceCallback))]
public interface ICalculatorService
{
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://calculatorService/ICalculatorService/AddTo")]
    void AddTo(double result);
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://calculatorService/ICalculatorService/AddTo")]
    System.Threading.Tasks.Task AddToAsync(double result);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ICalculatorServiceCallback
{
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://calculatorService/ICalculatorService/DisplayResult")]
    void DisplayResult(double result);
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://calculatorService/ICalculatorService/DisplayMethod")]
    void DisplayMethod(string methodName);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ICalculatorServiceChannel : ICalculatorService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class CalculatorServiceClient : System.ServiceModel.DuplexClientBase<ICalculatorService>, ICalculatorService
{
    
    public CalculatorServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
            base(callbackInstance)
    {
    }
    
    public CalculatorServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
            base(callbackInstance, endpointConfigurationName)
    {
    }
    
    public CalculatorServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
            base(callbackInstance, endpointConfigurationName, remoteAddress)
    {
    }
    
    public CalculatorServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(callbackInstance, endpointConfigurationName, remoteAddress)
    {
    }
    
    public CalculatorServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(callbackInstance, binding, remoteAddress)
    {
    }
    
    public void AddTo(double result)
    {
        base.Channel.AddTo(result);
    }
    
    public System.Threading.Tasks.Task AddToAsync(double result)
    {
        return base.Channel.AddToAsync(result);
    }
}
