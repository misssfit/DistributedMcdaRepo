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
            var httpUrl = StartService();
            var httpUrlAdmin = StartServiceAdmin();


            Console.WriteLine("Service is host at " + DateTime.UtcNow.ToString());
            Console.WriteLine("host at " + httpUrl.ToString());
            Console.WriteLine("admin at " + httpUrlAdmin.ToString());
            Console.WriteLine("Host is running... Press <Enter> key to stop");
            Console.ReadLine();
        }

        private static Uri StartService()
        {
            //Create a URI to serve as the base address
            Uri httpUrl = new Uri("http://localhost:8090/CalculationService/CalculatingService");
            //Create ServiceHost
            ServiceHost host = new ServiceHost(typeof(CalculatingEngine.CalculatingService), httpUrl);
            //Add a service endpoint
            var binding = new WSHttpBinding();
            binding.MaxReceivedMessageSize = 20000000;
            binding.MaxBufferPoolSize = 20000000;
            host.AddServiceEndpoint(typeof(CalculatingEngine.ICalculatingService), binding, "");
            //Enable metadata exchange
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            host.Description.Behaviors.Add(smb);
            //Start the Service
            host.Open();
            return httpUrl;
        }

        private static Uri StartServiceAdmin()
        {
            //Create a URI to serve as the base address
            Uri httpUrl = new Uri("http://localhost:8090/CalculationService/Administration");
            //Create ServiceHost
            ServiceHost host = new ServiceHost(typeof(CalculatingEngine.CalculatingService), httpUrl);
            //Add a service endpoint
            host.AddServiceEndpoint(typeof(CalculatingEngine.IAdministrationService), new WSHttpBinding(), "");
            //Enable metadata exchange
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            host.Description.Behaviors.Add(smb);
            //Start the Service
            host.Open();
            return httpUrl;
        }
    }
}
