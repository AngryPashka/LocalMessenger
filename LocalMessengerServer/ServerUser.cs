using System.ServiceModel;
namespace LocalMessengerServer
{
    public class ServerUser
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public OperationContext OperationContext { get; set; }
    }
}
