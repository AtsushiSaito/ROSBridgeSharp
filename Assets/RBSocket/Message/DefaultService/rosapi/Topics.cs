using System;

namespace RBS.Messages.rosapi
{
    [System.Serializable]
    public class TopicsRequest : ExtendMessage
    {
        public override string Type() { return "rosapi/Topics"; }
        public TopicsRequest()
        {
        }
    }

    [System.Serializable]
    public class TopicsResponse : ExtendMessage
    {
        public string[] topics;
        public string[] types;
        public override string Type() { return "rosapi/Topics"; }
        public TopicsResponse()
        {
            topics = new string[0];
            types = new string[0];
        }
    }
}