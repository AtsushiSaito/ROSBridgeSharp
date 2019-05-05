using System;

namespace RBS.Messages.actionlib_tutorials
{
    [System.Serializable]
    public class FibonacciActionGoal : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalID goal_id;
        public RBS.Messages.actionlib_tutorials.FibonacciGoal goal;
        public override string Type() { return "actionlib_tutorials/FibonacciActionGoal"; }
        public FibonacciActionGoal()
        {
            header = new RBS.Messages.std_msgs.Header();
            goal_id = new RBS.Messages.actionlib_msgs.GoalID();
            goal = new RBS.Messages.actionlib_tutorials.FibonacciGoal();
        }
    }
}