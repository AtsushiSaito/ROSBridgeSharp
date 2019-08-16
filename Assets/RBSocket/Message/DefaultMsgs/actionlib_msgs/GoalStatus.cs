using System;

namespace RBS.Messages.actionlib_msgs
{
    [System.Serializable]
    public class GoalStatus : ExtendMessage
    {
        public byte PENDING;
        public byte ACTIVE;
        public byte PREEMPTED;
        public byte SUCCEEDED;
        public byte ABORTED;
        public byte REJECTED;
        public byte PREEMPTING;
        public byte RECALLING;
        public byte RECALLED;
        public byte LOST;
        public RBS.Messages.actionlib_msgs.GoalID goal_id;
        public byte status;
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