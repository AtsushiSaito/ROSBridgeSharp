using System;

namespace RBS.Messages.rosapi
{
    [System.Serializable]
    public class ServicesRequest : ExtendMessage
    {
        public override string Type() { return "rosapi/Services"; }
        public ServicesRequest()
        {
        }
    }

    [System.Serializable]
    public class ServicesResponse : ExtendMessage
    {
        public string[] services;
        public override string Type() { return "rosapi/Services"; }
        public ServicesResponse()
        {
            services = new string[0];
        }
    }
}