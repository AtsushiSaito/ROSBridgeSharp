using System;

namespace RBS.Messages.std_srvs
{
    [System.Serializable]
    public class EmptyRequest : ExtendMessage
    {
        public override string Type() { return "std_srvs/Empty"; }
        public EmptyRequest()
        {
        }
    }

    [System.Serializable]
    public class EmptyResponse : ExtendMessage
    {
        public override string Type() { return "std_srvs/Empty"; }
        public EmptyResponse()
        {
        }
    }
}