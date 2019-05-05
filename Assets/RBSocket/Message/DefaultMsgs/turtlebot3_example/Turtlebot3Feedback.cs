using System;

namespace RBS.Messages.turtlebot3_example
{
    [System.Serializable]
    public class Turtlebot3Feedback : ExtendMessage
    {
        public string state;
        public override string Type() { return "turtlebot3_example/Turtlebot3Feedback"; }
        public Turtlebot3Feedback()
        {
            state = "";
        }
    }
}