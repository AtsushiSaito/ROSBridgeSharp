using System;

namespace RBS.Messages.actionlib
{
    [System.Serializable]
    public class TestActionFeedback : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalStatus status;
        public RBS.Messages.actionlib.TestFeedback feedback;
        public override string Type() { return "actionlib/TestActionFeedback"; }
        public TestActionFeedback()
        {
            header = new RBS.Messages.std_msgs.Header();
            status = new RBS.Messages.actionlib_msgs.GoalStatus();
            feedback = new RBS.Messages.actionlib.TestFeedback();
        }
    }
}