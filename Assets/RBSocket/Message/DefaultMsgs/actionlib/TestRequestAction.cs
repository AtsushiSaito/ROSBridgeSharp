using System;

namespace RBS.Messages.actionlib
{
    [System.Serializable]
    public class TestRequestAction : ExtendMessage
    {
        public RBS.Messages.actionlib.TestRequestActionGoal action_goal;
        public RBS.Messages.actionlib.TestRequestActionResult action_result;
        public RBS.Messages.actionlib.TestRequestActionFeedback action_feedback;
        public override string Type() { return "actionlib/TestRequestAction"; }
        public TestRequestAction()
        {
            action_goal = new RBS.Messages.actionlib.TestRequestActionGoal();
            action_result = new RBS.Messages.actionlib.TestRequestActionResult();
            action_feedback = new RBS.Messages.actionlib.TestRequestActionFeedback();
        }
    }
}