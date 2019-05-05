using System;

namespace RBS.Messages.tf2_msgs
{
    [System.Serializable]
    public class LookupTransformFeedback : ExtendMessage
    {
        public override string Type() { return "tf2_msgs/LookupTransformFeedback"; }
        public LookupTransformFeedback()
        {
        }
    }
}