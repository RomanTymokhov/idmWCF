using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace IdemDbWcfService
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true, ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.Single)]
    public class Service1 : IServiceDbWorker
    {
        public async void CreateIdemAcount(string email, string phone)
        {
            try
            {
                using (idemDatabaseEntities proxy = new idemDatabaseEntities())
                {
                    var queryStr = "insert into IdemAcount(email, phone) values ('" + email + "','" + phone + "');";
                    proxy.Database.ExecuteSqlCommand(queryStr);
                    await proxy.SaveChangesAsync();

                    //chek callback working
                    var serverCalback = OperationContext.Current.GetCallbackChannel<IServerCallback>();
                    serverCalback.SendInfo("idmUser Creating");
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("{0} Exception caught.", err);
                //logged this
            }
        }


    }
}
