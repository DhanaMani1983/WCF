using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Data;
using System.Text;
using WCFTraining.Data;
using WCFTraining.Model;

namespace WCFTraining.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SimpleInterest" in both code and config file together.
    public class SimpleInterest : ISimpleInterest
    {

        public double Calculate(double P, double R, double N)
        {
            try
            {
                double res = P * R * N / 100;
                return res;
            }
            catch (Exception e) {
                throw new FaultException<Exception>(e);
            }
        }


        public List<Customer> GetCustomers()
        {
            NORTHWNDEntities ctx = new NORTHWNDEntities();

            List<Customer> customers = (from c in ctx.Customers
                                        select c).ToList();
            return customers;
        }
    }
}
