using System;

namespace RBS.Messages.turtlebot3_example
{
    [System.Serializable]
    public class Turtlebot3Goal : ExtendMessage
    {
        public RBS.Messages.geometry_msgs.Vector3 goal;
        public override string Type() { return "turtlebot3_example/Turtlebot3Goal"; }
        public Turtlebot3Goal()
        {
            goal = new RBS.Messages.geometry_msgs.Vector3();
        }
    }
}