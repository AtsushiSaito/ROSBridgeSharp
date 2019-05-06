using System;

namespace RBS.Messages.roscpp
{
    [System.Serializable]
    public class EmptyRequest : ExtendMessage
    {
        public override string Type() { return "roscpp/Empty"; }
        public EmptyRequest()
        {
        }
    }

    [System.Serializable]
    public class EmptyResponse : ExtendMessage
    {
        public override string Type() { return "roscpp/Empty"; }
        public EmptyResponse()
        {
        }
    }
}