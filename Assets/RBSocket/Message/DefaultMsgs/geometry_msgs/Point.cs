using System;

namespace RBS.Messages.geometry_msgs
{
    [System.Serializable]
    public class Point : ExtendMessage
    {
        public double x;
        public double y;
        public double z;
        public override string Type() { return "geometry_msgs/Point"; }
        public Point()
        {
            x = 0.0f;
            y = 0.0f;
            z = 0.0f;
        }
    }
}