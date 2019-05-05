using System;

namespace RBS.Messages.rosbridge_msgs
{
    [System.Serializable]
    public class ConnectedClient : ExtendMessage
    {
        public string ip_address;
        public Time connection_time;
        public override string Type() { return "rosbridge_msgs/ConnectedClient"; }
        public ConnectedClient()
        {
            ip_address = "";
            connection_time = new Time();
        }
    }
}