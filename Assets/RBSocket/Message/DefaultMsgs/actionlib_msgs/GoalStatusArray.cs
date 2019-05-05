using System;

namespace RBS.Messages.actionlib_msgs
{
    [System.Serializable]
    public class GoalStatusArray : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalStatus[] status_list;
        public override string Type() { return "actionlib_msgs/GoalStatusArray"; }
        public GoalStatusArray()
        {
            header = new RBS.Messages.std_msgs.Header();
            status_list = new RBS.Messages.actionlib_msgs.GoalStatus[0];
        }
    }
}