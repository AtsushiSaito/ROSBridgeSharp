using System;

namespace RBS.Messages.geometry_msgs
{
    [System.Serializable]
    public class TwistWithCovariance : ExtendMessage
    {
        public RBS.Messages.geometry_msgs.Twist twist;
        public double[] covariance;
        public override string Type() { return "geometry_msgs/TwistWithCovariance"; }
        public TwistWithCovariance()
        {
            twist = new RBS.Messages.geometry_msgs.Twist();
            covariance = new double[36];
        }
    }
}