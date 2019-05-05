using System;

namespace RBS.Messages.geometry_msgs
{
    [System.Serializable]
    public class PoseStamped : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.geometry_msgs.Pose pose;
        public override string Type() { return "geometry_msgs/PoseStamped"; }
        public PoseStamped()
        {
            header = new RBS.Messages.std_msgs.Header();
            pose = new RBS.Messages.geometry_msgs.Pose();
        }
    }
}