using System.Collections.Generic;
using System.ServiceModel;

namespace LocalMessengerServer
{
	[ServiceContract(CallbackContract = typeof(IServerChatCallback))]
    public interface IServiceChat
    {
        [OperationContract]
        void Connect(int id, string name);

        [OperationContract]
        void Disconnect(int id);

        [OperationContract]
        List<string> ListName();

        [OperationContract(IsOneWay = true)]
        void SendMsg(byte[] encryptedData, int id);

        [OperationContract]
        int Authentication(string name, byte[] encryptedPassword);

        [OperationContract]
        List<byte[]> OldMessege();

        [OperationContract]
        byte[] GetPublicKey();

        [OperationContract]
        byte[] GetPrivateKey();
    }

    public interface IServerChatCallback
    {
        [OperationContract(IsOneWay = true)]
        void MsgCallback(byte[] encryptedData);

        [OperationContract(IsOneWay = true)]
        void ListUsersOnline(List<string> list);
    }
}
