namespace ROSBridgeSharp.Messages
{
    [System.Serializable]
    public class Vector3 : ExtendMessage
    {
        public float x;
        public float y;
        public float z;
        public override string Type() { return "geometry_msgs/Vector3"; }
    }
}