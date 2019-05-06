using System;

namespace RBS.Messages.map_msgs
{
    [System.Serializable]
    public class ProjectedMapsInfoRequest : ExtendMessage
    {
        public RBS.Messages.map_msgs.ProjectedMapInfo[] projected_maps_info;
        public override string Type() { return "map_msgs/ProjectedMapsInfo"; }
        public ProjectedMapsInfoRequest()
        {
            projected_maps_info = new RBS.Messages.map_msgs.ProjectedMapInfo[0];
        }
    }

    [System.Serializable]
    public class ProjectedMapsInfoResponse : ExtendMessage
    {
        public override string Type() { return "map_msgs/ProjectedMapsInfo"; }
        public ProjectedMapsInfoResponse()
        {
        }
    }
}