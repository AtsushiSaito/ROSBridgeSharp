using System;

namespace RBS.Messages.diagnostic_msgs
{
    [System.Serializable]
    public class DiagnosticArray : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.diagnostic_msgs.DiagnosticStatus[] status;
        public override string Type() { return "diagnostic_msgs/DiagnosticArray"; }
        public DiagnosticArray()
        {
            header = new RBS.Messages.std_msgs.Header();
            status = new RBS.Messages.diagnostic_msgs.DiagnosticStatus[0];
        }
    }
}