using System;

namespace RBS.Messages.geometry_msgs
{
    [System.Serializable]
    public class QuaternionStamped : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.geometry_msgs.Quaternion quaternion;
        public override string Type() { return "geometry_msgs/QuaternionStamped"; }
        public QuaternionStamped()
        {
            header = new RBS.Messages.std_msgs.Header();
            quaternion = new RBS.Messages.geometry_msgs.Quaternion();
        }
    }
}