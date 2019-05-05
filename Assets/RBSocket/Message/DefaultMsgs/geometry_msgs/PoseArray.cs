using System;

namespace RBS.Messages.geometry_msgs
{
    [System.Serializable]
    public class PoseArray : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.geometry_msgs.Pose[] poses;
        public override string Type() { return "geometry_msgs/PoseArray"; }
        public PoseArray()
        {
            header = new RBS.Messages.std_msgs.Header();
            poses = new RBS.Messages.geometry_msgs.Pose[0];
        }
    }
}