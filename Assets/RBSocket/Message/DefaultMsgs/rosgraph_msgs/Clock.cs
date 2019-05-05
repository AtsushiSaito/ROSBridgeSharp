using System;

namespace RBS.Messages.rosgraph_msgs
{
    [System.Serializable]
    public class Clock : ExtendMessage
    {
        public Time clock;
        public override string Type() { return "rosgraph_msgs/Clock"; }
        public Clock()
        {
            clock = new Time();
        }
    }
}