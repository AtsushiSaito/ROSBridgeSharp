using System;

namespace RBS.Messages.nav_msgs
{
    [System.Serializable]
    public class GetMapFeedback : ExtendMessage
    {
        public override string Type() { return "nav_msgs/GetMapFeedback"; }
        public GetMapFeedback()
        {
        }
    }
}