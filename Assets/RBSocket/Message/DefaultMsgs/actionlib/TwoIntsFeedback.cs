using System;

namespace RBS.Messages.actionlib
{
    [System.Serializable]
    public class TwoIntsFeedback : ExtendMessage
    {
        public override string Type() { return "actionlib/TwoIntsFeedback"; }
        public TwoIntsFeedback()
        {
        }
    }
}