using System;

namespace RBS.Messages.map_msgs
{
    [System.Serializable]
    public class GetPointMapRequest : ExtendMessage
    {
        public override string Type() { return "map_msgs/GetPointMap"; }
        public GetPointMapRequest()
        {
        }
    }

    [System.Serializable]
    public class GetPointMapResponse : ExtendMessage
    {
        public RBS.Messages.sensor_msgs.PointCloud2 map;
        public override string Type() { return "map_msgs/GetPointMap"; }
        public GetPointMapResponse()
        {
            map = new RBS.Messages.sensor_msgs.PointCloud2();
        }
    }
}