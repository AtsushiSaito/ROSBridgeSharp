using System;

namespace RBS.Messages.std_msgs
{
    [System.Serializable]
    public class UInt64 : ExtendMessage
    {
        public uint data;
        public override string Type() { return "std_msgs/UInt64"; }
        public UInt64()
        {
            data = 0;
        }
    }
}