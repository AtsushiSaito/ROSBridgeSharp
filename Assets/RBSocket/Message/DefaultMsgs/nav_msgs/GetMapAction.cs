using System;

namespace RBS.Messages.nav_msgs
{
    [System.Serializable]
    public class GetMapAction : ExtendMessage
    {
        public RBS.Messages.nav_msgs.GetMapActionGoal action_goal;
        public RBS.Messages.nav_msgs.GetMapActionResult action_result;
        public RBS.Messages.nav_msgs.GetMapActionFeedback action_feedback;
        public override string Type() { return "nav_msgs/GetMapAction"; }
        public GetMapAction()
        {
            action_goal = new RBS.Messages.nav_msgs.GetMapActionGoal();
            action_result = new RBS.Messages.nav_msgs.GetMapActionResult();
            action_feedback = new RBS.Messages.nav_msgs.GetMapActionFeedback();
        }
    }
}