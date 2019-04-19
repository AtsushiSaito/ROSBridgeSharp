namespace ROSBridgeSharp.Messages
{
    [System.Serializable]
    public class Pose : ExtendMessage
    {
        public Point position;
        public Quaternion orientation;
        public override string Type() { return "geometry_msgs/Pose"; }
    }
}