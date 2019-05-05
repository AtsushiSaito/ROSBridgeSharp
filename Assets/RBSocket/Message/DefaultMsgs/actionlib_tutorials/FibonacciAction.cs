using System;

namespace RBS.Messages.actionlib_tutorials
{
    [System.Serializable]
    public class FibonacciAction : ExtendMessage
    {
        public RBS.Messages.actionlib_tutorials.FibonacciActionGoal action_goal;
        public RBS.Messages.actionlib_tutorials.FibonacciActionResult action_result;
        public RBS.Messages.actionlib_tutorials.FibonacciActionFeedback action_feedback;
        public override string Type() { return "actionlib_tutorials/FibonacciAction"; }
        public FibonacciAction()
        {
            action_goal = new RBS.Messages.actionlib_tutorials.FibonacciActionGoal();
            action_result = new RBS.Messages.actionlib_tutorials.FibonacciActionResult();
            action_feedback = new RBS.Messages.actionlib_tutorials.FibonacciActionFeedback();
        }
    }
}