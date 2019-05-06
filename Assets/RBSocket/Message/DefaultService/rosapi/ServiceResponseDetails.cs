using System;

namespace RBS.Messages.rosapi
{
    [System.Serializable]
    public class ServiceResponseDetailsRequest : ExtendMessage
    {
        public string type;
        public override string Type() { return "rosapi/ServiceResponseDetails"; }
        public ServiceResponseDetailsRequest()
        {
            type = "";
        }
    }

    [System.Serializable]
    public class ServiceResponseDetailsResponse : ExtendMessage
    {
        public RBS.Messages.rosapi.TypeDef[] typedefs;
        public override string Type() { return "rosapi/ServiceResponseDetails"; }
        public ServiceResponseDetailsResponse()
        {
            typedefs = new RBS.Messages.rosapi.TypeDef[0];
        }
    }
}