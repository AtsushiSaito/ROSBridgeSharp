using System;

namespace RBS.Messages.move_base_msgs
{
    [System.Serializable]
    public class MoveBaseResult : ExtendMessage
    {
        public override string Type() { return "move_base_msgs/MoveBaseResult"; }
        public MoveBaseResult()
        {
        }
    }
}