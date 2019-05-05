using System;

namespace RBS.Messages.move_base_msgs
{
    [System.Serializable]
    public class MoveBaseActionFeedback : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalStatus status;
        public RBS.Messages.move_base_msgs.MoveBaseFeedback feedback;
        public override string Type() { return "move_base_msgs/MoveBaseActionFeedback"; }
        public MoveBaseActionFeedback()
        {
            header = new RBS.Messages.std_msgs.Header();
            status = new RBS.Messages.actionlib_msgs.GoalStatus();
            feedback = new RBS.Messages.move_base_msgs.MoveBaseFeedback();
        }
    }
}