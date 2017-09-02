using IdemWCF.IdemDbService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IdemWCF
{
    class ClientCallback:IService1Callback
    {
        public event Action<string> InfoSended;

        public void SendInfo(string info)
        {
            if (InfoSended != null) InfoSended(info);
        }
    }
}
