namespace RBS.Messages
{
    [System.Serializable]
    public class Quaternion : ExtendMessage
    {
        public float x;
        public float y;
        public float z;
        public float w;
        public override string Type() { return "geometry_msgs/Quaternion"; }
    }
}