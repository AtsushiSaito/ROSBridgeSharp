using System;

namespace RBS.Messages.std_msgs
{
    [System.Serializable]
    public class Int64 : ExtendMessage
    {
        public int data;
        public override string Type() { return "std_msgs/Int64"; }
        public Int64()
        {
            data = 0;
        }
    }
}