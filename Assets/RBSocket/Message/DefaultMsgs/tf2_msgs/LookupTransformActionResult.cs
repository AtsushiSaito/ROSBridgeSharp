using System;

namespace RBS.Messages.tf2_msgs
{
    [System.Serializable]
    public class LookupTransformActionResult : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalStatus status;
        public RBS.Messages.tf2_msgs.LookupTransformResult result;
        public override string Type() { return "tf2_msgs/LookupTransformActionResult"; }
        public LookupTransformActionResult()
        {
            header = new RBS.Messages.std_msgs.Header();
            status = new RBS.Messages.actionlib_msgs.GoalStatus();
            result = new RBS.Messages.tf2_msgs.LookupTransformResult();
        }
    }
}