using System;

namespace RBS.Messages.rosserial_msgs
{
    [System.Serializable]
    public class RequestMessageInfoRequest : ExtendMessage
    {
        public string type;
        public override string Type() { return "rosserial_msgs/RequestMessageInfo"; }
        public RequestMessageInfoRequest()
        {
            type = "";
        }
    }

    [System.Serializable]
    public class RequestMessageInfoResponse : ExtendMessage
    {
        public string md5;
        public string definition;
        public override string Type() { return "rosserial_msgs/RequestMessageInfo"; }
        public RequestMessageInfoResponse()
        {
            md5 = "";
            definition = "";
        }
    }
}