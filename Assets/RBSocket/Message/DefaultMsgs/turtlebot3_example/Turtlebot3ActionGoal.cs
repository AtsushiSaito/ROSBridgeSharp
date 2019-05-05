using System;

namespace RBS.Messages.turtlebot3_example
{
    [System.Serializable]
    public class Turtlebot3ActionGoal : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalID goal_id;
        public RBS.Messages.turtlebot3_example.Turtlebot3Goal goal;
        public override string Type() { return "turtlebot3_example/Turtlebot3ActionGoal"; }
        public Turtlebot3ActionGoal()
        {
            header = new RBS.Messages.std_msgs.Header();
            goal_id = new RBS.Messages.actionlib_msgs.GoalID();
            goal = new RBS.Messages.turtlebot3_example.Turtlebot3Goal();
        }
    }
}