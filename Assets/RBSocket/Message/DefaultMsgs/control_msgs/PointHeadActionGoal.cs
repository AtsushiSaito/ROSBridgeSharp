using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class PointHeadActionGoal : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalID goal_id;
        public RBS.Messages.control_msgs.PointHeadGoal goal;
        public override string Type() { return "control_msgs/PointHeadActionGoal"; }
        public PointHeadActionGoal()
        {
            header = new RBS.Messages.std_msgs.Header();
            goal_id = new RBS.Messages.actionlib_msgs.GoalID();
            goal = new RBS.Messages.control_msgs.PointHeadGoal();
        }
    }
}