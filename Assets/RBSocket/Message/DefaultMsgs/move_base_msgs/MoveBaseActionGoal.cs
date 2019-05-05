using System;

namespace RBS.Messages.move_base_msgs
{
    [System.Serializable]
    public class MoveBaseActionGoal : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalID goal_id;
        public RBS.Messages.move_base_msgs.MoveBaseGoal goal;
        public override string Type() { return "move_base_msgs/MoveBaseActionGoal"; }
        public MoveBaseActionGoal()
        {
            header = new RBS.Messages.std_msgs.Header();
            goal_id = new RBS.Messages.actionlib_msgs.GoalID();
            goal = new RBS.Messages.move_base_msgs.MoveBaseGoal();
        }
    }
}