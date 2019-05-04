namespace RBS.Messages
{
    [System.Serializable]
    public class Odometry : ExtendMessage
    {
        public Header header;
        public string child_frame_id;
        public PoseWithCovariance pose;
        public TwistWithCovariance twist;
        public override string Type() { return "nav_msgs/Odometry"; }
    }
}