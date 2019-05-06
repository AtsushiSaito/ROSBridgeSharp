using System;

namespace RBS.Messages.diagnostic_msgs
{
    [System.Serializable]
    public class SelfTestRequest : ExtendMessage
    {
        public override string Type() { return "diagnostic_msgs/SelfTest"; }
        public SelfTestRequest()
        {
        }
    }

    [System.Serializable]
    public class SelfTestResponse : ExtendMessage
    {
        public string id;
        public byte passed;
        public RBS.Messages.diagnostic_msgs.DiagnosticStatus[] status;
        public override string Type() { return "diagnostic_msgs/SelfTest"; }
        public SelfTestResponse()
        {
            id = "";
            passed = 0;
            status = new RBS.Messages.diagnostic_msgs.DiagnosticStatus[0];
        }
    }
}