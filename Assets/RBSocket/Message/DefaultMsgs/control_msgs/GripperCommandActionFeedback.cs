using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class GripperCommandActionFeedback : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalStatus status;
        public RBS.Messages.control_msgs.GripperCommandFeedback feedback;
        public override string Type() { return "control_msgs/GripperCommandActionFeedback"; }
        public GripperCommandActionFeedback()
        {
            header = new RBS.Messages.std_msgs.Header();
            status = new RBS.Messages.actionlib_msgs.GoalStatus();
            feedback = new RBS.Messages.control_msgs.GripperCommandFeedback();
        }
    }
}