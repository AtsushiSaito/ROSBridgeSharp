using System;

namespace RBS.Messages.rosapi
{
    [System.Serializable]
    public class ServiceRequestDetailsRequest : ExtendMessage
    {
        public string type;
        public override string Type() { return "rosapi/ServiceRequestDetails"; }
        public ServiceRequestDetailsRequest()
        {
            type = "";
        }
    }

    [System.Serializable]
    public class ServiceRequestDetailsResponse : ExtendMessage
    {
        public RBS.Messages.rosapi.TypeDef[] typedefs;
        public override string Type() { return "rosapi/ServiceRequestDetails"; }
        public ServiceRequestDetailsResponse()
        {
            typedefs = new RBS.Messages.rosapi.TypeDef[0];
        }
    }
}