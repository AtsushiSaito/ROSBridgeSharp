using System;

namespace RBS.Messages.std_srvs
{
    [System.Serializable]
    public class SetBoolRequest : ExtendMessage
    {
        public bool data;
        public override string Type() { return "std_srvs/SetBool"; }
        public SetBoolRequest()
        {
            data = false;
        }
    }

    [System.Serializable]
    public class SetBoolResponse : ExtendMessage
    {
        public bool success;
        public string message;
        public override string Type() { return "std_srvs/SetBool"; }
        public SetBoolResponse()
        {
            success = false;
            message = "";
        }
    }
}