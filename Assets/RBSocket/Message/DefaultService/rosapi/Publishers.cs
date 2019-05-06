using System;

namespace RBS.Messages.rosapi
{
    [System.Serializable]
    public class PublishersRequest : ExtendMessage
    {
        public string topic;
        public override string Type() { return "rosapi/Publishers"; }
        public PublishersRequest()
        {
            topic = "";
        }
    }

    [System.Serializable]
    public class PublishersResponse : ExtendMessage
    {
        public string[] publishers;
        public override string Type() { return "rosapi/Publishers"; }
        public PublishersResponse()
        {
            publishers = new string[0];
        }
    }
}