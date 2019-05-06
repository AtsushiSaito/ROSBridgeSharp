using System;

namespace RBS.Messages.rosapi
{
    [System.Serializable]
    public class MessageDetailsRequest : ExtendMessage
    {
        public string type;
        public override string Type() { return "rosapi/MessageDetails"; }
        public MessageDetailsRequest()
        {
            type = "";
        }
    }

    [System.Serializable]
    public class MessageDetailsResponse : ExtendMessage
    {
        public RBS.Messages.rosapi.TypeDef[] typedefs;
        public override string Type() { return "rosapi/MessageDetails"; }
        public MessageDetailsResponse()
        {
            typedefs = new RBS.Messages.rosapi.TypeDef[0];
        }
    }
}