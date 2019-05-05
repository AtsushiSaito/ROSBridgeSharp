using System;

namespace RBS.Messages.geometry_msgs
{
    [System.Serializable]
    public class WrenchStamped : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.geometry_msgs.Wrench wrench;
        public override string Type() { return "geometry_msgs/WrenchStamped"; }
        public WrenchStamped()
        {
            header = new RBS.Messages.std_msgs.Header();
            wrench = new RBS.Messages.geometry_msgs.Wrench();
        }
    }
}