using System;

namespace RBS.Messages.topic_tools
{
    [System.Serializable]
    public class MuxDeleteRequest : ExtendMessage
    {
        public string topic;
        public override string Type() { return "topic_tools/MuxDelete"; }
        public MuxDeleteRequest()
        {
            topic = "";
        }
    }

    [System.Serializable]
    public class MuxDeleteResponse : ExtendMessage
    {
        public override string Type() { return "topic_tools/MuxDelete"; }
        public MuxDeleteResponse()
        {
        }
    }
}