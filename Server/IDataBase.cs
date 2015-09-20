using System;
using System.ServiceModel;

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
