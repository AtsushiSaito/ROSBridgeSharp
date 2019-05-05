using System;

namespace RBS.Messages.std_msgs
{
    [System.Serializable]
    public class Byte : ExtendMessage
    {
        public byte data;
        public override string Type() { return "std_msgs/Byte"; }
        public Byte()
        {
            data = 0;
        }
    }
}