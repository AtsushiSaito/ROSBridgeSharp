using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class LinkStates : ExtendMessage
    {
        public string[] name;
        public RBS.Messages.geometry_msgs.Pose[] pose;
        public RBS.Messages.geometry_msgs.Twist[] twist;
        public override string Type() { return "gazebo_msgs/LinkStates"; }
        public LinkStates()
        {
            name = new string[0];
            pose = new RBS.Messages.geometry_msgs.Pose[0];
            twist = new RBS.Messages.geometry_msgs.Twist[0];
        }
    }
}