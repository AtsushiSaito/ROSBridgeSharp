using System;

namespace RBS.Messages.actionlib
{
    [System.Serializable]
    public class TestFeedback : ExtendMessage
    {
        public int feedback;
        public override string Type() { return "actionlib/TestFeedback"; }
        public TestFeedback()
        {
            feedback = 0;
        }
    }
}