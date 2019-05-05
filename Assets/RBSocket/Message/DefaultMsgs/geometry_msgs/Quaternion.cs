using System;

namespace RBS.Messages.geometry_msgs
{
    [System.Serializable]
    public class Quaternion : ExtendMessage
    {
        public double x;
        public double y;
        public double z;
        public double w;
        public override string Type() { return "geometry_msgs/Quaternion"; }
        public Quaternion()
        {
            x = 0.0f;
            y = 0.0f;
            z = 0.0f;
            w = 0.0f;
        }
    }
}