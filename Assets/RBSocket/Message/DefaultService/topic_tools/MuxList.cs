using System;

namespace RBS.Messages.topic_tools
{
    [System.Serializable]
    public class MuxListRequest : ExtendMessage
    {
        public override string Type() { return "topic_tools/MuxList"; }
        public MuxListRequest()
        {
        }
    }

    [System.Serializable]
    public class MuxListResponse : ExtendMessage
    {
        public string[] topics;
        public override string Type() { return "topic_tools/MuxList"; }
        public MuxListResponse()
        {
            topics = new string[0];
        }
    }
}