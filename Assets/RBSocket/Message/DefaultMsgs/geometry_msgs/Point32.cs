using System;

namespace RBS.Messages.geometry_msgs
{
    [System.Serializable]
    public class Point32 : ExtendMessage
    {
        public float x;
        public float y;
        public float z;
        public override string Type() { return "geometry_msgs/Point32"; }
        public Point32()
        {
            x = 0.0f;
            y = 0.0f;
            z = 0.0f;
        }
    }
}