using System;

namespace RBS.Messages.std_msgs
{
    [System.Serializable]
    public class Int16 : ExtendMessage
    {
        public int data;
        public override string Type() { return "std_msgs/Int16"; }
        public Int16()
        {
            data = 0;
        }
    }
}