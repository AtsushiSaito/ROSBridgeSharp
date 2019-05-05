using System;

namespace RBS.Messages.actionlib
{
    [System.Serializable]
    public class TestRequestActionGoal : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalID goal_id;
        public RBS.Messages.actionlib.TestRequestGoal goal;
        public override string Type() { return "actionlib/TestRequestActionGoal"; }
        public TestRequestActionGoal()
        {
            header = new RBS.Messages.std_msgs.Header();
            goal_id = new RBS.Messages.actionlib_msgs.GoalID();
            goal = new RBS.Messages.actionlib.TestRequestGoal();
        }
    }
}