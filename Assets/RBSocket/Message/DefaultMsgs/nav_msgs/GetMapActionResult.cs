using System;

namespace RBS.Messages.nav_msgs
{
    [System.Serializable]
    public class GetMapActionResult : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalStatus status;
        public RBS.Messages.nav_msgs.GetMapResult result;
        public override string Type() { return "nav_msgs/GetMapActionResult"; }
        public GetMapActionResult()
        {
            header = new RBS.Messages.std_msgs.Header();
            status = new RBS.Messages.actionlib_msgs.GoalStatus();
            result = new RBS.Messages.nav_msgs.GetMapResult();
        }
    }
}