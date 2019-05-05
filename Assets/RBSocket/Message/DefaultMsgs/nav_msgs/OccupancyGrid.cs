using System;

namespace RBS.Messages.nav_msgs
{
    [System.Serializable]
    public class OccupancyGrid : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.nav_msgs.MapMetaData info;
        public int[] data;
        public override string Type() { return "nav_msgs/OccupancyGrid"; }
        public OccupancyGrid()
        {
            header = new RBS.Messages.std_msgs.Header();
            info = new RBS.Messages.nav_msgs.MapMetaData();
            data = new int[0];
        }
    }
}