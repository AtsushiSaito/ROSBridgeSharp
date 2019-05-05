using System;

namespace RBS.Messages.actionlib
{
    [System.Serializable]
    public class TwoIntsActionResult : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalStatus status;
        public RBS.Messages.actionlib.TwoIntsResult result;
        public override string Type() { return "actionlib/TwoIntsActionResult"; }
        public TwoIntsActionResult()
        {
            header = new RBS.Messages.std_msgs.Header();
            status = new RBS.Messages.actionlib_msgs.GoalStatus();
            result = new RBS.Messages.actionlib.TwoIntsResult();
        }
    }
}