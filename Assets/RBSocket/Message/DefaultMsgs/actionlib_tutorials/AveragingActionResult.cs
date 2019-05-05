using System;

namespace RBS.Messages.actionlib_tutorials
{
    [System.Serializable]
    public class AveragingActionResult : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalStatus status;
        public RBS.Messages.actionlib_tutorials.AveragingResult result;
        public override string Type() { return "actionlib_tutorials/AveragingActionResult"; }
        public AveragingActionResult()
        {
            header = new RBS.Messages.std_msgs.Header();
            status = new RBS.Messages.actionlib_msgs.GoalStatus();
            result = new RBS.Messages.actionlib_tutorials.AveragingResult();
        }
    }
}