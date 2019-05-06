using System;

namespace RBS.Messages.nav_msgs
{
    [System.Serializable]
    public class GetMapRequest : ExtendMessage
    {
        public override string Type() { return "nav_msgs/GetMap"; }
        public GetMapRequest()
        {
        }
    }

    [System.Serializable]
    public class GetMapResponse : ExtendMessage
    {
        public RBS.Messages.nav_msgs.OccupancyGrid map;
        public override string Type() { return "nav_msgs/GetMap"; }
        public GetMapResponse()
        {
            map = new RBS.Messages.nav_msgs.OccupancyGrid();
        }
    }
}