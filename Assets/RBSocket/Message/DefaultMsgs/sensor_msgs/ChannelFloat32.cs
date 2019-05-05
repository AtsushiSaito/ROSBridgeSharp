using System;

namespace RBS.Messages.sensor_msgs
{
    [System.Serializable]
    public class ChannelFloat32 : ExtendMessage
    {
        public string name;
        public float[] values;
        public override string Type() { return "sensor_msgs/ChannelFloat32"; }
        public ChannelFloat32()
        {
            name = "";
            values = new float[0];
        }
    }
}