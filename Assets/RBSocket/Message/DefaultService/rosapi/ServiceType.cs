using System;

namespace RBS.Messages.rosapi
{
    [System.Serializable]
    public class ServiceTypeRequest : ExtendMessage
    {
        public string service;
        public override string Type() { return "rosapi/ServiceType"; }
        public ServiceTypeRequest()
        {
            service = "";
        }
    }

    [System.Serializable]
    public class ServiceTypeResponse : ExtendMessage
    {
        public string type;
        public override string Type() { return "rosapi/ServiceType"; }
        public ServiceTypeResponse()
        {
            type = "";
        }
    }
}