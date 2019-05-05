using System;

namespace RBS.Messages.actionlib
{
    [System.Serializable]
    public class TwoIntsGoal : ExtendMessage
    {
        public int a;
        public int b;
        public override string Type() { return "actionlib/TwoIntsGoal"; }
        public TwoIntsGoal()
        {
            a = 0;
            b = 0;
        }
    }
}