using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdemWCF
{
    interface IClientCallback
    {
        void SendInfo(string info);
    }
}
