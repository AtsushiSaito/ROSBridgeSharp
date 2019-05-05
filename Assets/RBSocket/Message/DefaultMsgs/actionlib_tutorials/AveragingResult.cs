using System;

namespace RBS.Messages.actionlib_tutorials
{
    [System.Serializable]
    public class AveragingResult : ExtendMessage
    {
        public float mean;
        public float std_dev;
        public override string Type() { return "actionlib_tutorials/AveragingResult"; }
        public AveragingResult()
        {
            mean = 0.0f;
            std_dev = 0.0f;
        }
    }
}