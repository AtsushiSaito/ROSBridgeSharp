using System;

namespace RBS.Messages.std_msgs
{
    [System.Serializable]
    public class Empty : ExtendMessage
    {
        public override string Type() { return "std_msgs/Empty"; }
        public Empty()
        {
        }
    }
}