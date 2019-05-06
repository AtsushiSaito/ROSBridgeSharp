using System;

namespace RBS.Messages.topic_tools
{
    [System.Serializable]
    public class MuxAddRequest : ExtendMessage
    {
        public string topic;
        public override string Type() { return "topic_tools/MuxAdd"; }
        public MuxAddRequest()
        {
            topic = "";
        }
    }

    [System.Serializable]
    public class MuxAddResponse : ExtendMessage
    {
        public override string Type() { return "topic_tools/MuxAdd"; }
        public MuxAddResponse()
        {
        }
    }
}