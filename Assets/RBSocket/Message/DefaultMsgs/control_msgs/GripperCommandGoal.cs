using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class GripperCommandGoal : ExtendMessage
    {
        public RBS.Messages.control_msgs.GripperCommand command;
        public override string Type() { return "control_msgs/GripperCommandGoal"; }
        public GripperCommandGoal()
        {
            command = new RBS.Messages.control_msgs.GripperCommand();
        }
    }
}