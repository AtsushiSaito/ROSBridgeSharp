using System;

namespace RBS.Messages.rosbridge_msgs
{
    [System.Serializable]
    public class ConnectedClients : ExtendMessage
    {
        public RBS.Messages.rosbridge_msgs.ConnectedClient[] clients;
        public override string Type() { return "rosbridge_msgs/ConnectedClients"; }
        public ConnectedClients()
        {
            clients = new RBS.Messages.rosbridge_msgs.ConnectedClient[0];
        }
    }
}