using System;

namespace RBS.Messages.diagnostic_msgs
{
    [System.Serializable]
    public class KeyValue : ExtendMessage
    {
        public string key;
        public string value;
        public override string Type() { return "diagnostic_msgs/KeyValue"; }
        public KeyValue()
        {
            key = "";
            value = "";
        }
    }
}