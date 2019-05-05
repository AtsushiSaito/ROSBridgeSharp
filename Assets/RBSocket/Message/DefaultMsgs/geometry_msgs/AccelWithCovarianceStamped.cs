using System;

namespace RBS.Messages.geometry_msgs
{
    [System.Serializable]
    public class AccelWithCovarianceStamped : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.geometry_msgs.AccelWithCovariance accel;
        public override string Type() { return "geometry_msgs/AccelWithCovarianceStamped"; }
        public AccelWithCovarianceStamped()
        {
            header = new RBS.Messages.std_msgs.Header();
            accel = new RBS.Messages.geometry_msgs.AccelWithCovariance();
        }
    }
}