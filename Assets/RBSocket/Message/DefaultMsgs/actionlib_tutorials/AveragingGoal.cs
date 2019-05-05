using System;

namespace RBS.Messages.actionlib_tutorials
{
    [System.Serializable]
    public class AveragingGoal : ExtendMessage
    {
        public int samples;
        public override string Type() { return "actionlib_tutorials/AveragingGoal"; }
        public AveragingGoal()
        {
            samples = 0;
        }
    }
}