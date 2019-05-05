using System;

namespace RBS.Messages.sensor_msgs
{
    [System.Serializable]
    public class PointCloud : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.geometry_msgs.Point32[] points;
        public RBS.Messages.sensor_msgs.ChannelFloat32[] channels;
        public override string Type() { return "sensor_msgs/PointCloud"; }
        public PointCloud()
        {
            header = new RBS.Messages.std_msgs.Header();
            points = new RBS.Messages.geometry_msgs.Point32[0];
            channels = new RBS.Messages.sensor_msgs.ChannelFloat32[0];
        }
    }
}