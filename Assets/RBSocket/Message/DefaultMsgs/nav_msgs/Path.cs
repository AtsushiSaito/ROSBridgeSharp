using System;

namespace RBS.Messages.nav_msgs
{
    [System.Serializable]
    public class Path : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.geometry_msgs.PoseStamped[] poses;
        public override string Type() { return "nav_msgs/Path"; }
        public Path()
        {
            header = new RBS.Messages.std_msgs.Header();
            poses = new RBS.Messages.geometry_msgs.PoseStamped[0];
        }
    }
}