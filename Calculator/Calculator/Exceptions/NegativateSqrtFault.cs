using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Exceptions
{
    [DataContract]
    public class NegativateSqrtFault
    {
        [DataMember]   
        public string CustomError; 
        public NegativateSqrtFault()  
        {   
        } 
        public NegativateSqrtFault(string error)  
        {   
            CustomError = error;   
        }
    }
}
