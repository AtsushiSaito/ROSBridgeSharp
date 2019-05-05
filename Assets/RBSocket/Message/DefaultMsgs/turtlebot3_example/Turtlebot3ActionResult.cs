using System;

namespace RBS.Messages.turtlebot3_example
{
    [System.Serializable]
    public class Turtlebot3ActionResult : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalStatus status;
        public RBS.Messages.turtlebot3_example.Turtlebot3Result result;
        public override string Type() { return "turtlebot3_example/Turtlebot3ActionResult"; }
        public Turtlebot3ActionResult()
        {
            header = new RBS.Messages.std_msgs.Header();
            status = new RBS.Messages.actionlib_msgs.GoalStatus();
            result = new RBS.Messages.turtlebot3_example.Turtlebot3Result();
        }
    }
}