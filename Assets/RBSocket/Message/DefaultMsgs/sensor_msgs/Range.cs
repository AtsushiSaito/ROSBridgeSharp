using System;

namespace RBS.Messages.sensor_msgs
{
    [System.Serializable]
    public class Range : ExtendMessage
    {
        public byte ULTRASOUND;
        public byte INFRARED;
        public RBS.Messages.std_msgs.Header header;
        public byte radiation_type;
        public float field_of_view;
        public float min_range;
        public float max_range;
        public float range;
        public override string Type() { return "sensor_msgs/Range"; }
        public Range()
        {
            ULTRASOUND = 0;
            INFRARED = 1;
            header = new RBS.Messages.std_msgs.Header();
            radiation_type = 0;
            field_of_view = 0.0f;
            min_range = 0.0f;
            max_range = 0.0f;
            range = 0.0f;
        }
    }
}