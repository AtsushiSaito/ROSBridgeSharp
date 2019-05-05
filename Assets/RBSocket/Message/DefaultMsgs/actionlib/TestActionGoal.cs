using System;

namespace RBS.Messages.actionlib
{
    [System.Serializable]
    public class TestActionGoal : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalID goal_id;
        public RBS.Messages.actionlib.TestGoal goal;
        public override string Type() { return "actionlib/TestActionGoal"; }
        public TestActionGoal()
        {
            header = new RBS.Messages.std_msgs.Header();
            goal_id = new RBS.Messages.actionlib_msgs.GoalID();
            goal = new RBS.Messages.actionlib.TestGoal();
        }
    }
}