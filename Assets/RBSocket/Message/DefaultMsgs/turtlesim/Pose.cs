using System;

namespace RBS.Messages.turtlesim
{
    [System.Serializable]
    public class Pose : ExtendMessage
    {
        public float x;
        public float y;
        public float theta;
        public float linear_velocity;
        public float angular_velocity;
        public override string Type() { return "turtlesim/Pose"; }
        public Pose()
        {
            x = 0.0f;
            y = 0.0f;
            theta = 0.0f;
            linear_velocity = 0.0f;
            angular_velocity = 0.0f;
        }
    }
}