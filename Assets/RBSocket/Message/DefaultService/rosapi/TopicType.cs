using System;

namespace RBS.Messages.rosapi
{
    [System.Serializable]
    public class TopicTypeRequest : ExtendMessage
    {
        public string topic;
        public override string Type() { return "rosapi/TopicType"; }
        public TopicTypeRequest()
        {
            topic = "";
        }
    }

    [System.Serializable]
    public class TopicTypeResponse : ExtendMessage
    {
        public string type;
        public override string Type() { return "rosapi/TopicType"; }
        public TopicTypeResponse()
        {
            type = "";
        }
    }
}