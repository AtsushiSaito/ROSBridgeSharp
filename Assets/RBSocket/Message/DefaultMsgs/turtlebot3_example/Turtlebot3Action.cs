using System;

namespace RBS.Messages.turtlebot3_example
{
    [System.Serializable]
    public class Turtlebot3Action : ExtendMessage
    {
        public RBS.Messages.turtlebot3_example.Turtlebot3ActionGoal action_goal;
        public RBS.Messages.turtlebot3_example.Turtlebot3ActionResult action_result;
        public RBS.Messages.turtlebot3_example.Turtlebot3ActionFeedback action_feedback;
        public override string Type() { return "turtlebot3_example/Turtlebot3Action"; }
        public Turtlebot3Action()
        {
            action_goal = new RBS.Messages.turtlebot3_example.Turtlebot3ActionGoal();
            action_result = new RBS.Messages.turtlebot3_example.Turtlebot3ActionResult();
            action_feedback = new RBS.Messages.turtlebot3_example.Turtlebot3ActionFeedback();
        }
    }
}