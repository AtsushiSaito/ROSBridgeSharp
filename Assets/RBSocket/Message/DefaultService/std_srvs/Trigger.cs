using System;

namespace RBS.Messages.std_srvs
{
    [System.Serializable]
    public class TriggerRequest : ExtendMessage
    {
        public override string Type() { return "std_srvs/Trigger"; }
        public TriggerRequest()
        {
        }
    }

    [System.Serializable]
    public class TriggerResponse : ExtendMessage
    {
        public bool success;
        public string message;
        public override string Type() { return "std_srvs/Trigger"; }
        public TriggerResponse()
        {
            success = false;
            message = "";
        }
    }
}