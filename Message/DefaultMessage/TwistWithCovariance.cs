namespace ROSBridgeSharp.Messages
{
    [System.Serializable]
    public class TwistWithCovariance : ExtendMessage
    {
        public Twist twist;
        public float[] covariance;
        public override string Type() { return "geometry_msgs/TwistWithCovariance"; }
    }
}