using System;

namespace RBS.Messages.turtle_actionlib
{
    [System.Serializable]
    public class ShapeAction : ExtendMessage
    {
        public RBS.Messages.turtle_actionlib.ShapeActionGoal action_goal;
        public RBS.Messages.turtle_actionlib.ShapeActionResult action_result;
        public RBS.Messages.turtle_actionlib.ShapeActionFeedback action_feedback;
        public override string Type() { return "turtle_actionlib/ShapeAction"; }
        public ShapeAction()
        {
            action_goal = new RBS.Messages.turtle_actionlib.ShapeActionGoal();
            action_result = new RBS.Messages.turtle_actionlib.ShapeActionResult();
            action_feedback = new RBS.Messages.turtle_actionlib.ShapeActionFeedback();
        }
    }
}