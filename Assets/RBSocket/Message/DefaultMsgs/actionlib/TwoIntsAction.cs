using System;

namespace RBS.Messages.actionlib
{
    [System.Serializable]
    public class TwoIntsAction : ExtendMessage
    {
        public RBS.Messages.actionlib.TwoIntsActionGoal action_goal;
        public RBS.Messages.actionlib.TwoIntsActionResult action_result;
        public RBS.Messages.actionlib.TwoIntsActionFeedback action_feedback;
        public override string Type() { return "actionlib/TwoIntsAction"; }
        public TwoIntsAction()
        {
            action_goal = new RBS.Messages.actionlib.TwoIntsActionGoal();
            action_result = new RBS.Messages.actionlib.TwoIntsActionResult();
            action_feedback = new RBS.Messages.actionlib.TwoIntsActionFeedback();
        }
    }
}