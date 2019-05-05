using System;

namespace RBS.Messages.geometry_msgs
{
    [System.Serializable]
    public class Pose2D : ExtendMessage
    {
        public double x;
        public double y;
        public double theta;
        public override string Type() { return "geometry_msgs/Pose2D"; }
        public Pose2D()
        {
            x = 0.0f;
            y = 0.0f;
            theta = 0.0f;
        }
    }
}