using System;

namespace RBS.Messages.actionlib
{
    [System.Serializable]
    public class TestGoal : ExtendMessage
    {
        public int goal;
        public override string Type() { return "actionlib/TestGoal"; }
        public TestGoal()
        {
            goal = 0;
        }
    }
}