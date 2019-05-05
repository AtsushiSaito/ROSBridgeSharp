using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class LinkState : ExtendMessage
    {
        public string link_name;
        public RBS.Messages.geometry_msgs.Pose pose;
        public RBS.Messages.geometry_msgs.Twist twist;
        public string reference_frame;
        public override string Type() { return "gazebo_msgs/LinkState"; }
        public LinkState()
        {
            link_name = "";
            pose = new RBS.Messages.geometry_msgs.Pose();
            twist = new RBS.Messages.geometry_msgs.Twist();
            reference_frame = "";
        }
    }
}