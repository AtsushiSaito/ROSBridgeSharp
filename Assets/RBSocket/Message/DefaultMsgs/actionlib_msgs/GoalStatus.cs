using System;

namespace RBS.Messages.actionlib_msgs
{
    [System.Serializable]
    public class GoalStatus : ExtendMessage
    {
        public uint PENDING;
        public uint ACTIVE;
        public uint PREEMPTED;
        public uint SUCCEEDED;
        public uint ABORTED;
        public uint REJECTED;
        public uint PREEMPTING;
        public uint RECALLING;
        public uint RECALLED;
        public uint LOST;
        public RBS.Messages.actionlib_msgs.GoalID goal_id;
        public uint status;
        public string text;
        public override string Type() { return "actionlib_msgs/GoalStatus"; }
        public GoalStatus()
        {
            PENDING = 0;
            ACTIVE = 1;
            PREEMPTED = 2;
            SUCCEEDED = 3;
            ABORTED = 4;
            REJECTED = 5;
            PREEMPTING = 6;
            RECALLING = 7;
            RECALLED = 8;
            LOST = 9;
            goal_id = new RBS.Messages.actionlib_msgs.GoalID();
            status = 0;
            text = "";
        }
    }
}