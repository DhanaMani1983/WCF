using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFTraining.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HelloWorld" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HelloWorld.svc or HelloWorld.svc.cs at the Solution Explorer and start debugging.
    public class HelloWorld : IHelloWorld
    {
         [WebInvoke(
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json)]
        public string Hello()
        {
            string res;
            res = "Hello World, The Server time is " + DateTime.Now.ToString();

            return res;
        }

         [WebInvoke(
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json)]
         public Person getPerson()
         {
             try {
                 Person res = new Person();
                 res.Name = "Ramu";
                 res.DateOfBirth = Convert.ToDateTime("01-Apr-1973");
                 return res;
             }
             catch (Exception e) {
                 throw new FaultException<Exception>(e);
             }
         }
    }
}
