using System;

namespace RBS.Messages.sensor_msgs
{
    [System.Serializable]
    public class Temperature : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public double temperature;
        public double variance;
        public override string Type() { return "sensor_msgs/Temperature"; }
        public Temperature()
        {
            header = new RBS.Messages.std_msgs.Header();
            temperature = 0.0f;
            variance = 0.0f;
        }
    }
}