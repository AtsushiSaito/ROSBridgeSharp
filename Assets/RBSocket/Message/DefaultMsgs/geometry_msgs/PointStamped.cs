using System;

namespace RBS.Messages.geometry_msgs
{
    [System.Serializable]
    public class PointStamped : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.geometry_msgs.Point point;
        public override string Type() { return "geometry_msgs/PointStamped"; }
        public PointStamped()
        {
            header = new RBS.Messages.std_msgs.Header();
            point = new RBS.Messages.geometry_msgs.Point();
        }
    }
}