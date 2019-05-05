using System;

namespace RBS.Messages.sensor_msgs
{
    [System.Serializable]
    public class TimeReference : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public Time time_ref;
        public string source;
        public override string Type() { return "sensor_msgs/TimeReference"; }
        public TimeReference()
        {
            header = new RBS.Messages.std_msgs.Header();
            time_ref = new Time();
            source = "";
        }
    }
}