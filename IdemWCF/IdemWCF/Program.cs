using IdemWCF.IdemDbService;
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
            Service1Client service = new Service1Client(new InstanceContext(callback));

            service.CreateIdemAcount("tohoff82", "380660785635");
        }
    }
}
