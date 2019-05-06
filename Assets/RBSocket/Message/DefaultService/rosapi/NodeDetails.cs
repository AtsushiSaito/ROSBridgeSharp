using System;

namespace RBS.Messages.rosapi
{
    [System.Serializable]
    public class NodeDetailsRequest : ExtendMessage
    {
        public string node;
        public override string Type() { return "rosapi/NodeDetails"; }
        public NodeDetailsRequest()
        {
            node = "";
        }
    }

    [System.Serializable]
    public class NodeDetailsResponse : ExtendMessage
    {
        public string[] subscribing;
        public string[] publishing;
        public string[] services;
        public override string Type() { return "rosapi/NodeDetails"; }
        public NodeDetailsResponse()
        {
            subscribing = new string[0];
            publishing = new string[0];
            services = new string[0];
        }
    }
}