using System;

namespace RBS.Messages.rosapi
{
    [System.Serializable]
    public class TopicsForTypeRequest : ExtendMessage
    {
        public string type;
        public override string Type() { return "rosapi/TopicsForType"; }
        public TopicsForTypeRequest()
        {
            type = "";
        }
    }

    [System.Serializable]
    public class TopicsForTypeResponse : ExtendMessage
    {
        public string[] topics;
        public override string Type() { return "rosapi/TopicsForType"; }
        public TopicsForTypeResponse()
        {
            topics = new string[0];
        }
    }
}