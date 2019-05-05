using System;

namespace RBS.Messages.std_msgs
{
    [System.Serializable]
    public class UInt64MultiArray : ExtendMessage
    {
        public RBS.Messages.std_msgs.MultiArrayLayout layout;
        public uint[] data;
        public override string Type() { return "std_msgs/UInt64MultiArray"; }
        public UInt64MultiArray()
        {
            layout = new RBS.Messages.std_msgs.MultiArrayLayout();
            data = new uint[0];
        }
    }
}