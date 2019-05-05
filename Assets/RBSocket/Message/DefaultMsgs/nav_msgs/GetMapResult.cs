using System;

namespace RBS.Messages.nav_msgs
{
    [System.Serializable]
    public class GetMapResult : ExtendMessage
    {
        public RBS.Messages.nav_msgs.OccupancyGrid map;
        public override string Type() { return "nav_msgs/GetMapResult"; }
        public GetMapResult()
        {
            map = new RBS.Messages.nav_msgs.OccupancyGrid();
        }
    }
}