using System;

namespace RBS.Messages.rosapi
{
    [System.Serializable]
    public class ServiceNodeRequest : ExtendMessage
    {
        public string service;
        public override string Type() { return "rosapi/ServiceNode"; }
        public ServiceNodeRequest()
        {
            service = "";
        }
    }

    [System.Serializable]
    public class ServiceNodeResponse : ExtendMessage
    {
        public string node;
        public override string Type() { return "rosapi/ServiceNode"; }
        public ServiceNodeResponse()
        {
            node = "";
        }
    }
}