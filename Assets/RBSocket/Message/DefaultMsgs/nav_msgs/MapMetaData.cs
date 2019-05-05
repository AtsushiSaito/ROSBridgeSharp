using System;

namespace RBS.Messages.nav_msgs
{
    [System.Serializable]
    public class MapMetaData : ExtendMessage
    {
        public Time map_load_time;
        public float resolution;
        public uint width;
        public uint height;
        public RBS.Messages.geometry_msgs.Pose origin;
        public override string Type() { return "nav_msgs/MapMetaData"; }
        public MapMetaData()
        {
            map_load_time = new Time();
            resolution = 0.0f;
            width = 0;
            height = 0;
            origin = new RBS.Messages.geometry_msgs.Pose();
        }
    }
}