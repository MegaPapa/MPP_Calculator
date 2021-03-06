﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.CalculatorReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ZeroDivideFault", Namespace="http://schemas.datacontract.org/2004/07/Calculator.Exceptions")]
    [System.SerializableAttribute()]
    public partial class ZeroDivideFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CustomErrorField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomError {
            get {
                return this.CustomErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomErrorField, value) != true)) {
                    this.CustomErrorField = value;
                    this.RaisePropertyChanged("CustomError");
                }
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NegativateSqrtFault", Namespace="http://schemas.datacontract.org/2004/07/Calculator.Exceptions")]
    [System.SerializableAttribute()]
    public partial class NegativateSqrtFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CustomErrorField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomError {
            get {
                return this.CustomErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomErrorField, value) != true)) {
                    this.CustomErrorField = value;
                    this.RaisePropertyChanged("CustomError");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculatorReference.ICalculator")]
    public interface ICalculator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Addition", ReplyAction="http://tempuri.org/ICalculator/AdditionResponse")]
        double Addition(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Addition", ReplyAction="http://tempuri.org/ICalculator/AdditionResponse")]
        System.Threading.Tasks.Task<double> AdditionAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Subtraction", ReplyAction="http://tempuri.org/ICalculator/SubtractionResponse")]
        double Subtraction(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Subtraction", ReplyAction="http://tempuri.org/ICalculator/SubtractionResponse")]
        System.Threading.Tasks.Task<double> SubtractionAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Multiplication", ReplyAction="http://tempuri.org/ICalculator/MultiplicationResponse")]
        double Multiplication(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Multiplication", ReplyAction="http://tempuri.org/ICalculator/MultiplicationResponse")]
        System.Threading.Tasks.Task<double> MultiplicationAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Division", ReplyAction="http://tempuri.org/ICalculator/DivisionResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Client.CalculatorReference.ZeroDivideFault), Action="http://tempuri.org/ICalculator/DivisionZeroDivideFaultFault", Name="ZeroDivideFault", Namespace="http://schemas.datacontract.org/2004/07/Calculator.Exceptions")]
        double Division(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Division", ReplyAction="http://tempuri.org/ICalculator/DivisionResponse")]
        System.Threading.Tasks.Task<double> DivisionAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Sqrt", ReplyAction="http://tempuri.org/ICalculator/SqrtResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Client.CalculatorReference.NegativateSqrtFault), Action="http://tempuri.org/ICalculator/SqrtNegativateSqrtFaultFault", Name="NegativateSqrtFault", Namespace="http://schemas.datacontract.org/2004/07/Calculator.Exceptions")]
        double Sqrt(double a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Sqrt", ReplyAction="http://tempuri.org/ICalculator/SqrtResponse")]
        System.Threading.Tasks.Task<double> SqrtAsync(double a);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorChannel : Client.CalculatorReference.ICalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorClient : System.ServiceModel.ClientBase<Client.CalculatorReference.ICalculator>, Client.CalculatorReference.ICalculator {
        
        public CalculatorClient() {
        }
        
        public CalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Addition(double a, double b) {
            return base.Channel.Addition(a, b);
        }
        
        public System.Threading.Tasks.Task<double> AdditionAsync(double a, double b) {
            return base.Channel.AdditionAsync(a, b);
        }
        
        public double Subtraction(double a, double b) {
            return base.Channel.Subtraction(a, b);
        }
        
        public System.Threading.Tasks.Task<double> SubtractionAsync(double a, double b) {
            return base.Channel.SubtractionAsync(a, b);
        }
        
        public double Multiplication(double a, double b) {
            return base.Channel.Multiplication(a, b);
        }
        
        public System.Threading.Tasks.Task<double> MultiplicationAsync(double a, double b) {
            return base.Channel.MultiplicationAsync(a, b);
        }
        
        public double Division(double a, double b) {
            return base.Channel.Division(a, b);
        }
        
        public System.Threading.Tasks.Task<double> DivisionAsync(double a, double b) {
            return base.Channel.DivisionAsync(a, b);
        }
        
        public double Sqrt(double a) {
            return base.Channel.Sqrt(a);
        }
        
        public System.Threading.Tasks.Task<double> SqrtAsync(double a) {
            return base.Channel.SqrtAsync(a);
        }
    }
}
