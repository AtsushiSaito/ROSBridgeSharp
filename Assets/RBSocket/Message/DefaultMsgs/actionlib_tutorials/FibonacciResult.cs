using System;

namespace RBS.Messages.actionlib_tutorials
{
    [System.Serializable]
    public class FibonacciResult : ExtendMessage
    {
        public int[] sequence;
        public override string Type() { return "actionlib_tutorials/FibonacciResult"; }
        public FibonacciResult()
        {
            sequence = new int[0];
        }
    }
}