using System;

namespace RBS.Messages.actionlib_tutorials
{
    [System.Serializable]
    public class AveragingFeedback : ExtendMessage
    {
        public int sample;
        public float data;
        public float mean;
        public float std_dev;
        public override string Type() { return "actionlib_tutorials/AveragingFeedback"; }
        public AveragingFeedback()
        {
            sample = 0;
            data = 0.0f;
            mean = 0.0f;
            std_dev = 0.0f;
        }
    }
}