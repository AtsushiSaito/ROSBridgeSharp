using System;

namespace RBS.Messages.topic_tools
{
    [System.Serializable]
    public class DemuxAddRequest : ExtendMessage
    {
        public string topic;
        public override string Type() { return "topic_tools/DemuxAdd"; }
        public DemuxAddRequest()
        {
            topic = "";
        }
    }

    [System.Serializable]
    public class DemuxAddResponse : ExtendMessage
    {
        public override string Type() { return "topic_tools/DemuxAdd"; }
        public DemuxAddResponse()
        {
        }
    }
}