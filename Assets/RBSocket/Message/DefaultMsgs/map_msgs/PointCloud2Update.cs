using System;

namespace RBS.Messages.map_msgs
{
    [System.Serializable]
    public class PointCloud2Update : ExtendMessage
    {
        public uint ADD;
        public uint DELETE;
        public RBS.Messages.std_msgs.Header header;
        public uint type;
        public RBS.Messages.sensor_msgs.PointCloud2 points;
        public override string Type() { return "map_msgs/PointCloud2Update"; }
        public PointCloud2Update()
        {
            ADD = 0;
            DELETE = 1;
            header = new RBS.Messages.std_msgs.Header();
            type = 0;
            points = new RBS.Messages.sensor_msgs.PointCloud2();
        }
    }
}