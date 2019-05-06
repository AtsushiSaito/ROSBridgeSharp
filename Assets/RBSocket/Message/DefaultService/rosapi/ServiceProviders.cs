using System;

namespace RBS.Messages.rosapi
{
    [System.Serializable]
    public class ServiceProvidersRequest : ExtendMessage
    {
        public string service;
        public override string Type() { return "rosapi/ServiceProviders"; }
        public ServiceProvidersRequest()
        {
            service = "";
        }
    }

    [System.Serializable]
    public class ServiceProvidersResponse : ExtendMessage
    {
        public string[] providers;
        public override string Type() { return "rosapi/ServiceProviders"; }
        public ServiceProvidersResponse()
        {
            providers = new string[0];
        }
    }
}