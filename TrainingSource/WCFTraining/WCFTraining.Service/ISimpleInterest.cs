using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFTraining.Data;
using WCFTraining.Model;

namespace WCFTraining.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISimpleInterest" in both code and config file together.
    [ServiceContract]
    public interface ISimpleInterest
    {
        [OperationContract]
        double Calculate(double P, double R, double N);

        [OperationContract]
        List<Customer> GetCustomers();
    }
}
