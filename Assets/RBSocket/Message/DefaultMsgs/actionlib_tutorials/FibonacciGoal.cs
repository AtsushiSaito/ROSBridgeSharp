using System;

namespace RBS.Messages.actionlib_tutorials
{
    [System.Serializable]
    public class FibonacciGoal : ExtendMessage
    {
        public int order;
        public override string Type() { return "actionlib_tutorials/FibonacciGoal"; }
        public FibonacciGoal()
        {
            order = 0;
        }
    }
}