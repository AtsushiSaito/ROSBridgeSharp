using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class GripperCommandResult : ExtendMessage
    {
        public double position;
        public double effort;
        public bool stalled;
        public bool reached_goal;
        public override string Type() { return "control_msgs/GripperCommandResult"; }
        public GripperCommandResult()
        {
            position = 0.0f;
            effort = 0.0f;
            stalled = false;
            reached_goal = false;
        }
    }
}