using System;

namespace RBS.Messages.geometry_msgs
{
    [System.Serializable]
    public class PoseWithCovariance : ExtendMessage
    {
        public RBS.Messages.geometry_msgs.Pose pose;
        public double[] covariance;
        public override string Type() { return "geometry_msgs/PoseWithCovariance"; }
        public PoseWithCovariance()
        {
            pose = new RBS.Messages.geometry_msgs.Pose();
            covariance = new double[36];
        }
    }
}