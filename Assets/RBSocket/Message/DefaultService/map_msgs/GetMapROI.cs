using System;

namespace RBS.Messages.map_msgs
{
    [System.Serializable]
    public class GetMapROIRequest : ExtendMessage
    {
        public double x;
        public double y;
        public double l_x;
        public double l_y;
        public override string Type() { return "map_msgs/GetMapROI"; }
        public GetMapROIRequest()
        {
            x = 0.0f;
            y = 0.0f;
            l_x = 0.0f;
            l_y = 0.0f;
        }
    }

    [System.Serializable]
    public class GetMapROIResponse : ExtendMessage
    {
        public RBS.Messages.nav_msgs.OccupancyGrid sub_map;
        public override string Type() { return "map_msgs/GetMapROI"; }
        public GetMapROIResponse()
        {
            sub_map = new RBS.Messages.nav_msgs.OccupancyGrid();
        }
    }
}