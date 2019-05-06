using System;

namespace RBS.Messages.topic_tools
{
    [System.Serializable]
    public class DemuxSelectRequest : ExtendMessage
    {
        public string topic;
        public override string Type() { return "topic_tools/DemuxSelect"; }
        public DemuxSelectRequest()
        {
            topic = "";
        }
    }

    [System.Serializable]
    public class DemuxSelectResponse : ExtendMessage
    {
        public string prev_topic;
        public override string Type() { return "topic_tools/DemuxSelect"; }
        public DemuxSelectResponse()
        {
            prev_topic = "";
        }
    }
}