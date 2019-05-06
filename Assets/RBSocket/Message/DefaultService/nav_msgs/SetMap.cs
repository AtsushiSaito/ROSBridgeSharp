using System;

namespace RBS.Messages.nav_msgs
{
    [System.Serializable]
    public class SetMapRequest : ExtendMessage
    {
        public RBS.Messages.nav_msgs.OccupancyGrid map;
        public RBS.Messages.geometry_msgs.PoseWithCovarianceStamped initial_pose;
        public override string Type() { return "nav_msgs/SetMap"; }
        public SetMapRequest()
        {
            map = new RBS.Messages.nav_msgs.OccupancyGrid();
            initial_pose = new RBS.Messages.geometry_msgs.PoseWithCovarianceStamped();
        }
    }

    [System.Serializable]
    public class SetMapResponse : ExtendMessage
    {
        public bool success;
        public override string Type() { return "nav_msgs/SetMap"; }
        public SetMapResponse()
        {
            success = false;
        }
    }
}