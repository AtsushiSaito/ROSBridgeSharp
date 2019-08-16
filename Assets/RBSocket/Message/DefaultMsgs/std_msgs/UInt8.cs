using System;

namespace RBS.Messages.std_msgs
{
    [System.Serializable]
    public class UInt8 : ExtendMessage
    {
        public byte data;
        public override string Type() { return "std_msgs/UInt8"; }
        public UInt8()
        {
            data = 0;
        }
    }
}