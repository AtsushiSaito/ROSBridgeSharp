using System;

namespace RBS.Messages.sensor_msgs
{
    [System.Serializable]
    public class RelativeHumidity : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public double relative_humidity;
        public double variance;
        public override string Type() { return "sensor_msgs/RelativeHumidity"; }
        public RelativeHumidity()
        {
            header = new RBS.Messages.std_msgs.Header();
            relative_humidity = 0.0f;
            variance = 0.0f;
        }
    }
}