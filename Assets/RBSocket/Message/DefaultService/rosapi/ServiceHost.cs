using System;

namespace RBS.Messages.rosapi
{
    [System.Serializable]
    public class ServiceHostRequest : ExtendMessage
    {
        public string service;
        public override string Type() { return "rosapi/ServiceHost"; }
        public ServiceHostRequest()
        {
            service = "";
        }
    }

    [System.Serializable]
    public class ServiceHostResponse : ExtendMessage
    {
        public string host;
        public override string Type() { return "rosapi/ServiceHost"; }
        public ServiceHostResponse()
        {
            host = "";
        }
    }
}