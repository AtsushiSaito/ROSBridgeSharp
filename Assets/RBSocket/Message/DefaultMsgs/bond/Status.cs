using System;

namespace RBS.Messages.bond
{
    [System.Serializable]
    public class Status : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public string id;
        public string instance_id;
        public bool active;
        public float heartbeat_timeout;
        public float heartbeat_period;
        public override string Type() { return "bond/Status"; }
        public Status()
        {
            header = new RBS.Messages.std_msgs.Header();
            id = "";
            instance_id = "";
            active = false;
            heartbeat_timeout = 0.0f;
            heartbeat_period = 0.0f;
        }
    }
}