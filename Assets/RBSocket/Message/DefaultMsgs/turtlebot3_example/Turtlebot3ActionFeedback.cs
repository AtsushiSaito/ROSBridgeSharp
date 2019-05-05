using System;

namespace RBS.Messages.turtlebot3_example
{
    [System.Serializable]
    public class Turtlebot3ActionFeedback : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalStatus status;
        public RBS.Messages.turtlebot3_example.Turtlebot3Feedback feedback;
        public override string Type() { return "turtlebot3_example/Turtlebot3ActionFeedback"; }
        public Turtlebot3ActionFeedback()
        {
            header = new RBS.Messages.std_msgs.Header();
            status = new RBS.Messages.actionlib_msgs.GoalStatus();
            feedback = new RBS.Messages.turtlebot3_example.Turtlebot3Feedback();
        }
    }
}