using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class GripperCommand : ExtendMessage
    {
        public double position;
        public double max_effort;
        public override string Type() { return "control_msgs/GripperCommand"; }
        public GripperCommand()
        {
            position = 0.0f;
            max_effort = 0.0f;
        }
    }
}