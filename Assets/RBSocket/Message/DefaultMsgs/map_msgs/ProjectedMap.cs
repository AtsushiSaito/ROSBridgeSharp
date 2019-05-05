using System;

namespace RBS.Messages.map_msgs
{
    [System.Serializable]
    public class ProjectedMap : ExtendMessage
    {
        public RBS.Messages.nav_msgs.OccupancyGrid map;
        public double min_z;
        public double max_z;
        public override string Type() { return "map_msgs/ProjectedMap"; }
        public ProjectedMap()
        {
            map = new RBS.Messages.nav_msgs.OccupancyGrid();
            min_z = 0.0f;
            max_z = 0.0f;
        }
    }
}