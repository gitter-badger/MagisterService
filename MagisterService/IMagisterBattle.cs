﻿using BattleLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MagisterService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMagisterBattle
    {

        [OperationContract]
        string LogIn(string name, string pass);

        [OperationContract]
        Battle GetBattleState(string UserKey, string battleID);

        [OperationContract]
        string StartBattle(string UserKey);

        [OperationContract]
        bool TakeTurn(RoundAction Turn, string UserKey, string BattleKey);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
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
