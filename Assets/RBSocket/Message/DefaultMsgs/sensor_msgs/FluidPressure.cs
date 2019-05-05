using System;

namespace RBS.Messages.sensor_msgs
{
    [System.Serializable]
    public class FluidPressure : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public double fluid_pressure;
        public double variance;
        public override string Type() { return "sensor_msgs/FluidPressure"; }
        public FluidPressure()
        {
            header = new RBS.Messages.std_msgs.Header();
            fluid_pressure = 0.0f;
            variance = 0.0f;
        }
    }
}