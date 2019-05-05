using System;

namespace RBS.Messages.actionlib
{
    [System.Serializable]
    public class TestRequestFeedback : ExtendMessage
    {
        public override string Type() { return "actionlib/TestRequestFeedback"; }
        public TestRequestFeedback()
        {
        }
    }
}