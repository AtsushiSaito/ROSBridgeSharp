using System;

namespace RBS.Messages.topic_tools
{
    [System.Serializable]
    public class DemuxListRequest : ExtendMessage
    {
        public override string Type() { return "topic_tools/DemuxList"; }
        public DemuxListRequest()
        {
        }
    }

    [System.Serializable]
    public class DemuxListResponse : ExtendMessage
    {
        public string[] topics;
        public override string Type() { return "topic_tools/DemuxList"; }
        public DemuxListResponse()
        {
            topics = new string[0];
        }
    }
}