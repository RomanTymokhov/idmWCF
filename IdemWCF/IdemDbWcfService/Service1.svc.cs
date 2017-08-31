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
    public class Service1 : IService1
    {
        IServerCallback serverCallback;

        public async void CreateIdemAcount(string email, string phone)
        {
            try
            {
                using (idemDatabaseEntities dbProcessor = new idemDatabaseEntities())
                {
                    var queryStr = "insert into IdemAcount(email, phone) values ('" + email + "','" + phone + "');";
                    dbProcessor.Database.ExecuteSqlCommand(queryStr);
                    await dbProcessor.SaveChangesAsync();
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("{0} Exception caught.", err);
                //loggeed this
            }
        }


    }
}
