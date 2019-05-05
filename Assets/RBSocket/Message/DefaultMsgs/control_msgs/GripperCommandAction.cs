using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class GripperCommandAction : ExtendMessage
    {
        public RBS.Messages.control_msgs.GripperCommandActionGoal action_goal;
        public RBS.Messages.control_msgs.GripperCommandActionResult action_result;
        public RBS.Messages.control_msgs.GripperCommandActionFeedback action_feedback;
        public override string Type() { return "control_msgs/GripperCommandAction"; }
        public GripperCommandAction()
        {
            action_goal = new RBS.Messages.control_msgs.GripperCommandActionGoal();
            action_result = new RBS.Messages.control_msgs.GripperCommandActionResult();
            action_feedback = new RBS.Messages.control_msgs.GripperCommandActionFeedback();
        }
    }
}