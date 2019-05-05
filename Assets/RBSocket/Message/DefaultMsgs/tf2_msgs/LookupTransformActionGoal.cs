using System;

namespace RBS.Messages.tf2_msgs
{
    [System.Serializable]
    public class LookupTransformActionGoal : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalID goal_id;
        public RBS.Messages.tf2_msgs.LookupTransformGoal goal;
        public override string Type() { return "tf2_msgs/LookupTransformActionGoal"; }
        public LookupTransformActionGoal()
        {
            header = new RBS.Messages.std_msgs.Header();
            goal_id = new RBS.Messages.actionlib_msgs.GoalID();
            goal = new RBS.Messages.tf2_msgs.LookupTransformGoal();
        }
    }
}