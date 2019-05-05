using System;

namespace RBS.Messages.turtlebot3_example
{
    [System.Serializable]
    public class Turtlebot3Result : ExtendMessage
    {
        public string result;
        public override string Type() { return "turtlebot3_example/Turtlebot3Result"; }
        public Turtlebot3Result()
        {
            result = "";
        }
    }
}