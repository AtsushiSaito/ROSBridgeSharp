using System;

namespace RBS.Messages.rosserial_msgs
{
    [System.Serializable]
    public class RequestServiceInfoRequest : ExtendMessage
    {
        public string service;
        public override string Type() { return "rosserial_msgs/RequestServiceInfo"; }
        public RequestServiceInfoRequest()
        {
            service = "";
        }
    }

    [System.Serializable]
    public class RequestServiceInfoResponse : ExtendMessage
    {
        public string service_md5;
        public string request_md5;
        public string response_md5;
        public override string Type() { return "rosserial_msgs/RequestServiceInfo"; }
        public RequestServiceInfoResponse()
        {
            service_md5 = "";
            request_md5 = "";
            response_md5 = "";
        }
    }
}