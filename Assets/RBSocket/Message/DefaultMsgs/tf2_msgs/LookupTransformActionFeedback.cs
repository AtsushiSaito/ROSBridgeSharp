using System;

namespace RBS.Messages.tf2_msgs
{
    [System.Serializable]
    public class LookupTransformActionFeedback : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalStatus status;
        public RBS.Messages.tf2_msgs.LookupTransformFeedback feedback;
        public override string Type() { return "tf2_msgs/LookupTransformActionFeedback"; }
        public LookupTransformActionFeedback()
        {
            header = new RBS.Messages.std_msgs.Header();
            status = new RBS.Messages.actionlib_msgs.GoalStatus();
            feedback = new RBS.Messages.tf2_msgs.LookupTransformFeedback();
        }
    }
}