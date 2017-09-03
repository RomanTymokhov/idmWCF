using IdemWCF.IdemService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IdemWCF
{
    class Program
    {

        static void Main(string[] args)
        {
            var callback = new ClientCallback();

            callback.InfoSended += info =>
            {
                Console.WriteLine(info);
            };

            ServiceDbWorkerClient service = new ServiceDbWorkerClient(new InstanceContext(callback));

            service.CreateIdemAcount("tohoff82", "380660785635");

            Console.Read();
        }
    }
}
