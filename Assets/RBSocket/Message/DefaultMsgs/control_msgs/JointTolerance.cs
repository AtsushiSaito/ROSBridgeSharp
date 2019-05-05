using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class JointTolerance : ExtendMessage
    {
        public string name;
        public double position;
        public double velocity;
        public double acceleration;
        public override string Type() { return "control_msgs/JointTolerance"; }
        public JointTolerance()
        {
            name = "";
            position = 0.0f;
            velocity = 0.0f;
            acceleration = 0.0f;
        }
    }
}