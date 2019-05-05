using System;

namespace RBS.Messages.std_msgs
{
    [System.Serializable]
    public class Int8 : ExtendMessage
    {
        public int data;
        public override string Type() { return "std_msgs/Int8"; }
        public Int8()
        {
            data = 0;
        }
    }
}