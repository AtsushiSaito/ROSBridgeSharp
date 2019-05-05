using System;

namespace RBS.Messages.geometry_msgs
{
    [System.Serializable]
    public class AccelWithCovariance : ExtendMessage
    {
        public RBS.Messages.geometry_msgs.Accel accel;
        public double[] covariance;
        public override string Type() { return "geometry_msgs/AccelWithCovariance"; }
        public AccelWithCovariance()
        {
            accel = new RBS.Messages.geometry_msgs.Accel();
            covariance = new double[36];
        }
    }
}