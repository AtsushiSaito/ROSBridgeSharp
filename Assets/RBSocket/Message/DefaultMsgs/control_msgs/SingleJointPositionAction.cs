using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class SingleJointPositionAction : ExtendMessage
    {
        public RBS.Messages.control_msgs.SingleJointPositionActionGoal action_goal;
        public RBS.Messages.control_msgs.SingleJointPositionActionResult action_result;
        public RBS.Messages.control_msgs.SingleJointPositionActionFeedback action_feedback;
        public override string Type() { return "control_msgs/SingleJointPositionAction"; }
        public SingleJointPositionAction()
        {
            action_goal = new RBS.Messages.control_msgs.SingleJointPositionActionGoal();
            action_result = new RBS.Messages.control_msgs.SingleJointPositionActionResult();
            action_feedback = new RBS.Messages.control_msgs.SingleJointPositionActionFeedback();
        }
    }
}