using System;

namespace RBS.Messages.geometry_msgs
{
    [System.Serializable]
    public class Vector3 : ExtendMessage
    {
        public double x;
        public double y;
        public double z;
        public override string Type() { return "geometry_msgs/Vector3"; }
        public Vector3()
        {
            x = 0.0f;
            y = 0.0f;
            z = 0.0f;
        }
    }
}