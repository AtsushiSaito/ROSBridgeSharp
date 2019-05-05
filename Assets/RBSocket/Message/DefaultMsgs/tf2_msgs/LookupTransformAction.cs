using System;

namespace RBS.Messages.tf2_msgs
{
    [System.Serializable]
    public class LookupTransformAction : ExtendMessage
    {
        public RBS.Messages.tf2_msgs.LookupTransformActionGoal action_goal;
        public RBS.Messages.tf2_msgs.LookupTransformActionResult action_result;
        public RBS.Messages.tf2_msgs.LookupTransformActionFeedback action_feedback;
        public override string Type() { return "tf2_msgs/LookupTransformAction"; }
        public LookupTransformAction()
        {
            action_goal = new RBS.Messages.tf2_msgs.LookupTransformActionGoal();
            action_result = new RBS.Messages.tf2_msgs.LookupTransformActionResult();
            action_feedback = new RBS.Messages.tf2_msgs.LookupTransformActionFeedback();
        }
    }
}