using System;

namespace RBS.Messages.rosapi
{
    [System.Serializable]
    public class SubscribersRequest : ExtendMessage
    {
        public string topic;
        public override string Type() { return "rosapi/Subscribers"; }
        public SubscribersRequest()
        {
            topic = "";
        }
    }

    [System.Serializable]
    public class SubscribersResponse : ExtendMessage
    {
        public string[] subscribers;
        public override string Type() { return "rosapi/Subscribers"; }
        public SubscribersResponse()
        {
            subscribers = new string[0];
        }
    }
}