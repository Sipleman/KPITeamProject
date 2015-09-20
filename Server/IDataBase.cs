using System;
using System.ServiceModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    [ServiceContract]
    public interface IDataBase
    {
        [OperationContract]
        int Authorizate(string username, string password);

        [OperationContract]
        int Registration(string username, string password);
    }
}
