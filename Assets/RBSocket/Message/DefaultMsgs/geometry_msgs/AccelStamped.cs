using System;

namespace RBS.Messages.geometry_msgs
{
    [System.Serializable]
    public class AccelStamped : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.geometry_msgs.Accel accel;
        public override string Type() { return "geometry_msgs/AccelStamped"; }
        public AccelStamped()
        {
            header = new RBS.Messages.std_msgs.Header();
            accel = new RBS.Messages.geometry_msgs.Accel();
        }
    }
}