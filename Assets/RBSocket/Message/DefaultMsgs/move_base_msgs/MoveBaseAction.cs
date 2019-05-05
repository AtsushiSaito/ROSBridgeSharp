using System;

namespace RBS.Messages.move_base_msgs
{
    [System.Serializable]
    public class MoveBaseAction : ExtendMessage
    {
        public RBS.Messages.move_base_msgs.MoveBaseActionGoal action_goal;
        public RBS.Messages.move_base_msgs.MoveBaseActionResult action_result;
        public RBS.Messages.move_base_msgs.MoveBaseActionFeedback action_feedback;
        public override string Type() { return "move_base_msgs/MoveBaseAction"; }
        public MoveBaseAction()
        {
            action_goal = new RBS.Messages.move_base_msgs.MoveBaseActionGoal();
            action_result = new RBS.Messages.move_base_msgs.MoveBaseActionResult();
            action_feedback = new RBS.Messages.move_base_msgs.MoveBaseActionFeedback();
        }
    }
}