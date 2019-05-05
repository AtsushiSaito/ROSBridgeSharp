using System;

namespace RBS.Messages.actionlib_msgs
{
    [System.Serializable]
    public class GoalID : ExtendMessage
    {
        public Time stamp;
        public string id;
        public override string Type() { return "actionlib_msgs/GoalID"; }
        public GoalID()
        {
            stamp = new Time();
            id = "";
        }
    }
}