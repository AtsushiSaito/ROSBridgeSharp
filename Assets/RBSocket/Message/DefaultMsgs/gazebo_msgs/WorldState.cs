using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class WorldState : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public string[] name;
        public RBS.Messages.geometry_msgs.Pose[] pose;
        public RBS.Messages.geometry_msgs.Twist[] twist;
        public RBS.Messages.geometry_msgs.Wrench[] wrench;
        public override string Type() { return "gazebo_msgs/WorldState"; }
        public WorldState()
        {
            header = new RBS.Messages.std_msgs.Header();
            name = new string[0];
            pose = new RBS.Messages.geometry_msgs.Pose[0];
            twist = new RBS.Messages.geometry_msgs.Twist[0];
            wrench = new RBS.Messages.geometry_msgs.Wrench[0];
        }
    }
}