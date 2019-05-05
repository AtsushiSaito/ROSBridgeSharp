using System;

namespace RBS.Messages.actionlib
{
    [System.Serializable]
    public class TestAction : ExtendMessage
    {
        public RBS.Messages.actionlib.TestActionGoal action_goal;
        public RBS.Messages.actionlib.TestActionResult action_result;
        public RBS.Messages.actionlib.TestActionFeedback action_feedback;
        public override string Type() { return "actionlib/TestAction"; }
        public TestAction()
        {
            action_goal = new RBS.Messages.actionlib.TestActionGoal();
            action_result = new RBS.Messages.actionlib.TestActionResult();
            action_feedback = new RBS.Messages.actionlib.TestActionFeedback();
        }
    }
}