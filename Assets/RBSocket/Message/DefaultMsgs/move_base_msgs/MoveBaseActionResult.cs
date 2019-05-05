using System;

namespace RBS.Messages.move_base_msgs
{
    [System.Serializable]
    public class MoveBaseActionResult : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalStatus status;
        public RBS.Messages.move_base_msgs.MoveBaseResult result;
        public override string Type() { return "move_base_msgs/MoveBaseActionResult"; }
        public MoveBaseActionResult()
        {
            header = new RBS.Messages.std_msgs.Header();
            status = new RBS.Messages.actionlib_msgs.GoalStatus();
            result = new RBS.Messages.move_base_msgs.MoveBaseResult();
        }
    }
}