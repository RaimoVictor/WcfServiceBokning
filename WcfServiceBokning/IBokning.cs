﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceBokning
{

   
    [ServiceContract]
    public interface IBokning //ny kommentar från algots branch
    {

        [OperationContract]
        string GetData(int value); //algotskommentar // Victors kommentar

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        
    }


   
   
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
