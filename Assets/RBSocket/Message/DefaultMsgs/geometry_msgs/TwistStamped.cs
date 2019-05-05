using System;

namespace RBS.Messages.geometry_msgs
{
    [System.Serializable]
    public class TwistStamped : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.geometry_msgs.Twist twist;
        public override string Type() { return "geometry_msgs/TwistStamped"; }
        public TwistStamped()
        {
            header = new RBS.Messages.std_msgs.Header();
            twist = new RBS.Messages.geometry_msgs.Twist();
        }
    }
}