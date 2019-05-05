using System;

namespace RBS.Messages.map_msgs
{
    [System.Serializable]
    public class ProjectedMapInfo : ExtendMessage
    {
        public string frame_id;
        public double x;
        public double y;
        public double width;
        public double height;
        public double min_z;
        public double max_z;
        public override string Type() { return "map_msgs/ProjectedMapInfo"; }
        public ProjectedMapInfo()
        {
            frame_id = "";
            x = 0.0f;
            y = 0.0f;
            width = 0.0f;
            height = 0.0f;
            min_z = 0.0f;
            max_z = 0.0f;
        }
    }
}