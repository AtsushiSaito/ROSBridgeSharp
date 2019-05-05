using System;

namespace RBS.Messages.sensor_msgs
{
    [System.Serializable]
    public class Illuminance : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public double illuminance;
        public double variance;
        public override string Type() { return "sensor_msgs/Illuminance"; }
        public Illuminance()
        {
            header = new RBS.Messages.std_msgs.Header();
            illuminance = 0.0f;
            variance = 0.0f;
        }
    }
}