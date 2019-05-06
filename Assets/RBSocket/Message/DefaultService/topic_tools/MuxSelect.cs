using System;

namespace RBS.Messages.topic_tools
{
    [System.Serializable]
    public class MuxSelectRequest : ExtendMessage
    {
        public string topic;
        public override string Type() { return "topic_tools/MuxSelect"; }
        public MuxSelectRequest()
        {
            topic = "";
        }
    }

    [System.Serializable]
    public class MuxSelectResponse : ExtendMessage
    {
        public string prev_topic;
        public override string Type() { return "topic_tools/MuxSelect"; }
        public MuxSelectResponse()
        {
            prev_topic = "";
        }
    }
}