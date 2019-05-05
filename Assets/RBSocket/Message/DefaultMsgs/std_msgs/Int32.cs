using System;

namespace RBS.Messages.std_msgs
{
    [System.Serializable]
    public class Int32 : ExtendMessage
    {
        public int data;
        public override string Type() { return "std_msgs/Int32"; }
        public Int32()
        {
            data = 0;
        }
    }
}