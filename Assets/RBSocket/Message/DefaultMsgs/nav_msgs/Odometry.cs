using System;

namespace RBS.Messages.nav_msgs
{
    [System.Serializable]
    public class Odometry : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public string child_frame_id;
        public RBS.Messages.geometry_msgs.PoseWithCovariance pose;
        public RBS.Messages.geometry_msgs.TwistWithCovariance twist;
        public override string Type() { return "nav_msgs/Odometry"; }
        public Odometry()
        {
            header = new RBS.Messages.std_msgs.Header();
            child_frame_id = "";
            pose = new RBS.Messages.geometry_msgs.PoseWithCovariance();
            twist = new RBS.Messages.geometry_msgs.TwistWithCovariance();
        }
    }
}