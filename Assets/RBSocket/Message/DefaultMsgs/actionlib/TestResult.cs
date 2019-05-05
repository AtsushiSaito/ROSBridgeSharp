using System;

namespace RBS.Messages.actionlib
{
    [System.Serializable]
    public class TestResult : ExtendMessage
    {
        public int result;
        public override string Type() { return "actionlib/TestResult"; }
        public TestResult()
        {
            result = 0;
        }
    }
}