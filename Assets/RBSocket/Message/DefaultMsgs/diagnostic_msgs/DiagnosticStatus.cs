using System;

namespace RBS.Messages.diagnostic_msgs
{
    [System.Serializable]
    public class DiagnosticStatus : ExtendMessage
    {
        public byte OK;
        public byte WARN;
        public byte ERROR;
        public byte STALE;
        public byte level;
        public string name;
        public string message;
        public string hardware_id;
        public RBS.Messages.diagnostic_msgs.KeyValue[] values;
        public override string Type() { return "diagnostic_msgs/DiagnosticStatus"; }
        public DiagnosticStatus()
        {
            OK = 0;
            WARN = 1;
            ERROR = 2;
            STALE = 3;
            level = 0;
            name = "";
            message = "";
            hardware_id = "";
            values = new RBS.Messages.diagnostic_msgs.KeyValue[0];
        }
    }
}