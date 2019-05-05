using System;

namespace RBS.Messages.nav_msgs
{
    [System.Serializable]
    public class GetMapGoal : ExtendMessage
    {
        public override string Type() { return "nav_msgs/GetMapGoal"; }
        public GetMapGoal()
        {
        }
    }
}