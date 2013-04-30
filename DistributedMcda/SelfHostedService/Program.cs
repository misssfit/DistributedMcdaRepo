using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace SelfHostedService
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a URI to serve as the base address
            Uri httpUrl = new Uri("http://localhost:8090/CalculationService/CalculatingService");
            //Create ServiceHost
            ServiceHost host = new ServiceHost(typeof(CalculatingEngine.CalculatingService), httpUrl);
            //Add a service endpoint
            host.AddServiceEndpoint(typeof(CalculatingEngine.ICalculatingService), new WSHttpBinding(), "");
            //Enable metadata exchange
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            host.Description.Behaviors.Add(smb);
            //Start the Service
            host.Open();

            Console.WriteLine("Service is host at " + DateTime.UtcNow.ToString());
            Console.WriteLine("host at " + httpUrl.ToString());
            Console.WriteLine("Host is running... Press <Enter> key to stop");
            Console.ReadLine();	
        }
    }
}
