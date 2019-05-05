using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class PointHeadAction : ExtendMessage
    {
        public RBS.Messages.control_msgs.PointHeadActionGoal action_goal;
        public RBS.Messages.control_msgs.PointHeadActionResult action_result;
        public RBS.Messages.control_msgs.PointHeadActionFeedback action_feedback;
        public override string Type() { return "control_msgs/PointHeadAction"; }
        public PointHeadAction()
        {
            action_goal = new RBS.Messages.control_msgs.PointHeadActionGoal();
            action_result = new RBS.Messages.control_msgs.PointHeadActionResult();
            action_feedback = new RBS.Messages.control_msgs.PointHeadActionFeedback();
        }
    }
}