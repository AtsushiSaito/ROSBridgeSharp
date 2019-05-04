namespace RBS.Messages
{
    [System.Serializable]
    public class Point : ExtendMessage
    {
        public float x;
        public float y;
        public float z;
        public override string Type() { return "geometry_msgs/Point"; }
    }
}