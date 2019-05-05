using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class SingleJointPositionActionFeedback : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalStatus status;
        public RBS.Messages.control_msgs.SingleJointPositionFeedback feedback;
        public override string Type() { return "control_msgs/SingleJointPositionActionFeedback"; }
        public SingleJointPositionActionFeedback()
        {
            header = new RBS.Messages.std_msgs.Header();
            status = new RBS.Messages.actionlib_msgs.GoalStatus();
            feedback = new RBS.Messages.control_msgs.SingleJointPositionFeedback();
        }
    }
}