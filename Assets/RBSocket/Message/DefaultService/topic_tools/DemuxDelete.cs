using System;

namespace RBS.Messages.topic_tools
{
    [System.Serializable]
    public class DemuxDeleteRequest : ExtendMessage
    {
        public string topic;
        public override string Type() { return "topic_tools/DemuxDelete"; }
        public DemuxDeleteRequest()
        {
            topic = "";
        }
    }

    [System.Serializable]
    public class DemuxDeleteResponse : ExtendMessage
    {
        public override string Type() { return "topic_tools/DemuxDelete"; }
        public DemuxDeleteResponse()
        {
        }
    }
}