using System;

namespace RBS.Messages.geometry_msgs
{
    [System.Serializable]
    public class PoseWithCovarianceStamped : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.geometry_msgs.PoseWithCovariance pose;
        public override string Type() { return "geometry_msgs/PoseWithCovarianceStamped"; }
        public PoseWithCovarianceStamped()
        {
            header = new RBS.Messages.std_msgs.Header();
            pose = new RBS.Messages.geometry_msgs.PoseWithCovariance();
        }
    }
}