using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class PointHeadResult : ExtendMessage
    {
        public override string Type() { return "control_msgs/PointHeadResult"; }
        public PointHeadResult()
        {
        }
    }
}