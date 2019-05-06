using System;

namespace RBS.Messages.rosapi
{
    [System.Serializable]
    public class ServicesForTypeRequest : ExtendMessage
    {
        public string type;
        public override string Type() { return "rosapi/ServicesForType"; }
        public ServicesForTypeRequest()
        {
            type = "";
        }
    }

    [System.Serializable]
    public class ServicesForTypeResponse : ExtendMessage
    {
        public string[] services;
        public override string Type() { return "rosapi/ServicesForType"; }
        public ServicesForTypeResponse()
        {
            services = new string[0];
        }
    }
}