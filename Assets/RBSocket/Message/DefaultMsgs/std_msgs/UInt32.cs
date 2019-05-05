using System;

namespace RBS.Messages.std_msgs
{
    [System.Serializable]
    public class UInt32 : ExtendMessage
    {
        public uint data;
        public override string Type() { return "std_msgs/UInt32"; }
        public UInt32()
        {
            data = 0;
        }
    }
}