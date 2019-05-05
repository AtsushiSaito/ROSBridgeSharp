using System;

namespace RBS.Messages.geometry_msgs
{
    [System.Serializable]
    public class TwistWithCovarianceStamped : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.geometry_msgs.TwistWithCovariance twist;
        public override string Type() { return "geometry_msgs/TwistWithCovarianceStamped"; }
        public TwistWithCovarianceStamped()
        {
            header = new RBS.Messages.std_msgs.Header();
            twist = new RBS.Messages.geometry_msgs.TwistWithCovariance();
        }
    }
}