﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICalculator")]
public interface ICalculator
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Addition", ReplyAction="http://tempuri.org/ICalculator/AdditionResponse")]
    double Addition(int num1, int num2);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Subtraction", ReplyAction="http://tempuri.org/ICalculator/SubtractionResponse")]
    double Subtraction(int num1, int num2);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Multiplication", ReplyAction="http://tempuri.org/ICalculator/MultiplicationResponse")]
    double Multiplication(int num1, int num2);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Division", ReplyAction="http://tempuri.org/ICalculator/DivisionResponse")]
    double Division(int num1, int num2);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ICalculatorChannel : ICalculator, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class CalculatorClient : System.ServiceModel.ClientBase<ICalculator>, ICalculator
{
    
    public CalculatorClient()
    {
    }
    
    public CalculatorClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public CalculatorClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public double Addition(int num1, int num2)
    {
        return base.Channel.Addition(num1, num2);
    }
    
    public double Subtraction(int num1, int num2)
    {
        return base.Channel.Subtraction(num1, num2);
    }
    
    public double Multiplication(int num1, int num2)
    {
        return base.Channel.Multiplication(num1, num2);
    }
    
    public double Division(int num1, int num2)
    {
        return base.Channel.Division(num1, num2);
    }
}