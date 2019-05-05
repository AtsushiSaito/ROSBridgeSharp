using System;

namespace RBS.Messages.actionlib_tutorials
{
    [System.Serializable]
    public class FibonacciActionFeedback : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalStatus status;
        public RBS.Messages.actionlib_tutorials.FibonacciFeedback feedback;
        public override string Type() { return "actionlib_tutorials/FibonacciActionFeedback"; }
        public FibonacciActionFeedback()
        {
            header = new RBS.Messages.std_msgs.Header();
            status = new RBS.Messages.actionlib_msgs.GoalStatus();
            feedback = new RBS.Messages.actionlib_tutorials.FibonacciFeedback();
        }
    }
}