using System;

namespace RBS.Messages.std_msgs
{
    [System.Serializable]
    public class UInt16 : ExtendMessage
    {
        public uint data;
        public override string Type() { return "std_msgs/UInt16"; }
        public UInt16()
        {
            data = 0;
        }
    }
}