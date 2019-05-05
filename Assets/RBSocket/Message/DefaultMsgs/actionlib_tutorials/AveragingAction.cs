using System;

namespace RBS.Messages.actionlib_tutorials
{
    [System.Serializable]
    public class AveragingAction : ExtendMessage
    {
        public RBS.Messages.actionlib_tutorials.AveragingActionGoal action_goal;
        public RBS.Messages.actionlib_tutorials.AveragingActionResult action_result;
        public RBS.Messages.actionlib_tutorials.AveragingActionFeedback action_feedback;
        public override string Type() { return "actionlib_tutorials/AveragingAction"; }
        public AveragingAction()
        {
            action_goal = new RBS.Messages.actionlib_tutorials.AveragingActionGoal();
            action_result = new RBS.Messages.actionlib_tutorials.AveragingActionResult();
            action_feedback = new RBS.Messages.actionlib_tutorials.AveragingActionFeedback();
        }
    }
}