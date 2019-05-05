using System;

namespace RBS.Messages.actionlib_tutorials
{
    [System.Serializable]
    public class FibonacciFeedback : ExtendMessage
    {
        public int[] sequence;
        public override string Type() { return "actionlib_tutorials/FibonacciFeedback"; }
        public FibonacciFeedback()
        {
            sequence = new int[0];
        }
    }
}