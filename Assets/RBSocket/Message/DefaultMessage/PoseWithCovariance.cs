namespace RBS.Messages
{
    [System.Serializable]
    public class PoseWithCovariance : ExtendMessage
    {
        public Pose pose;
        public float[] covariance;
        public override string Type() { return "geometry_msgs/PoseWithCovariance"; }
    }
}