using System;

namespace RBS.Messages.actionlib
{
    [System.Serializable]
    public class TestRequestActionFeedback : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalStatus status;
        public RBS.Messages.actionlib.TestRequestFeedback feedback;
        public override string Type() { return "actionlib/TestRequestActionFeedback"; }
        public TestRequestActionFeedback()
        {
            header = new RBS.Messages.std_msgs.Header();
            status = new RBS.Messages.actionlib_msgs.GoalStatus();
            feedback = new RBS.Messages.actionlib.TestRequestFeedback();
        }
    }
}