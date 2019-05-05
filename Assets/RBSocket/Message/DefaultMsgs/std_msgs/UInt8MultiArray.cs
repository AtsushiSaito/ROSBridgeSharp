using System;

namespace RBS.Messages.std_msgs
{
    [System.Serializable]
    public class UInt8MultiArray : ExtendMessage
    {
        public RBS.Messages.std_msgs.MultiArrayLayout layout;
        public uint[] data;
        public override string Type() { return "std_msgs/UInt8MultiArray"; }
        public UInt8MultiArray()
        {
            layout = new RBS.Messages.std_msgs.MultiArrayLayout();
            data = new uint[0];
        }
    }
}