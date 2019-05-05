using System;

namespace RBS.Messages.nav_msgs
{
    [System.Serializable]
    public class GetMapActionFeedback : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalStatus status;
        public RBS.Messages.nav_msgs.GetMapFeedback feedback;
        public override string Type() { return "nav_msgs/GetMapActionFeedback"; }
        public GetMapActionFeedback()
        {
            header = new RBS.Messages.std_msgs.Header();
            status = new RBS.Messages.actionlib_msgs.GoalStatus();
            feedback = new RBS.Messages.nav_msgs.GetMapFeedback();
        }
    }
}