using System;

namespace RBS.Messages.map_msgs
{
    [System.Serializable]
    public class OccupancyGridUpdate : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public int x;
        public int y;
        public uint width;
        public uint height;
        public int[] data;
        public override string Type() { return "map_msgs/OccupancyGridUpdate"; }
        public OccupancyGridUpdate()
        {
            header = new RBS.Messages.std_msgs.Header();
            x = 0;
            y = 0;
            width = 0;
            height = 0;
            data = new int[0];
        }
    }
}