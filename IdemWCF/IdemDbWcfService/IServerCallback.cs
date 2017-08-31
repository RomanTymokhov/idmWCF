using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IdemDbWcfService
{
    public interface IServerCallback
    {
        [OperationContract(IsOneWay = true)]
        void SendInfo(string info);
    }
}
