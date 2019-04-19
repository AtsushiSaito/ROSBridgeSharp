namespace ROSBridgeSharp.Messages
{
    [System.Serializable]
    public class Header : ExtendMessage
    {
        public uint seq;
        public Time stamp;
        public string frame_id;
        public override string Type() { return "geometry_msgs/Vector3"; }
    }
}