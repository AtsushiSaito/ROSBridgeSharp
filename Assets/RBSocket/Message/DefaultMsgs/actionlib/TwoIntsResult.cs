using System;

namespace RBS.Messages.actionlib
{
    [System.Serializable]
    public class TwoIntsResult : ExtendMessage
    {
        public int sum;
        public override string Type() { return "actionlib/TwoIntsResult"; }
        public TwoIntsResult()
        {
            sum = 0;
        }
    }
}