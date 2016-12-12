using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Calculator.Exceptions
{
    [DataContract]
    public class ZeroDivideFault
    {
        [DataMember]   
        public string CustomError; 
        public ZeroDivideFault()  
        {   
        } 
        public ZeroDivideFault(string error)  
        {   
            CustomError = error;   
        }
    }
}