using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace IdemDbWcfService
{
    [ServiceContract(CallbackContract = typeof(IServerCallback))]
    public interface IService1
    {
        [OperationContract(IsOneWay = true)]
        void CreateIdemAcount(string email, string phone);
    }
}
