using System;

namespace RBS.Messages.map_msgs
{
    [System.Serializable]
    public class GetPointMapROIRequest : ExtendMessage
    {
        public double x;
        public double y;
        public double z;
        public double r;
        public double l_x;
        public double l_y;
        public double l_z;
        public override string Type() { return "map_msgs/GetPointMapROI"; }
        public GetPointMapROIRequest()
        {
            x = 0.0f;
            y = 0.0f;
            z = 0.0f;
            r = 0.0f;
            l_x = 0.0f;
            l_y = 0.0f;
            l_z = 0.0f;
        }
    }

    [System.Serializable]
    public class GetPointMapROIResponse : ExtendMessage
    {
        public RBS.Messages.sensor_msgs.PointCloud2 sub_map;
        public override string Type() { return "map_msgs/GetPointMapROI"; }
        public GetPointMapROIResponse()
        {
            sub_map = new RBS.Messages.sensor_msgs.PointCloud2();
        }
    }
}