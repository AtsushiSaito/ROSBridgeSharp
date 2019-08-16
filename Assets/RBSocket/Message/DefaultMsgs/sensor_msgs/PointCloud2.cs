using System;

namespace RBS.Messages.sensor_msgs
{
    [System.Serializable]
    public class PointCloud2 : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public uint height;
        public uint width;
        public RBS.Messages.sensor_msgs.PointField[] fields;
        public bool is_bigendian;
        public uint point_step;
        public uint row_step;
        public string data;
        public bool is_dense;
        public override string Type() { return "sensor_msgs/PointCloud2"; }
        public PointCloud2()
        {
            header = new RBS.Messages.std_msgs.Header();
            height = 0;
            width = 0;
            fields = new RBS.Messages.sensor_msgs.PointField[0];
            is_bigendian = false;
            point_step = 0;
            row_step = 0;
            data = "";
            is_dense = false;
        }
    }
}