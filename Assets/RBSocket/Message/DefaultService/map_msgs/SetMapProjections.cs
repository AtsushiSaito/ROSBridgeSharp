using System;

namespace RBS.Messages.map_msgs
{
    [System.Serializable]
    public class SetMapProjectionsRequest : ExtendMessage
    {
        public override string Type() { return "map_msgs/SetMapProjections"; }
        public SetMapProjectionsRequest()
        {
        }
    }

    [System.Serializable]
    public class SetMapProjectionsResponse : ExtendMessage
    {
        public RBS.Messages.map_msgs.ProjectedMapInfo[] projected_maps_info;
        public override string Type() { return "map_msgs/SetMapProjections"; }
        public SetMapProjectionsResponse()
        {
            projected_maps_info = new RBS.Messages.map_msgs.ProjectedMapInfo[0];
        }
    }
}