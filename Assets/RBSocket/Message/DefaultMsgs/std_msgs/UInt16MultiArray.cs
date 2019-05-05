using System;

namespace RBS.Messages.std_msgs
{
    [System.Serializable]
    public class UInt16MultiArray : ExtendMessage
    {
        public RBS.Messages.std_msgs.MultiArrayLayout layout;
        public uint[] data;
        public override string Type() { return "std_msgs/UInt16MultiArray"; }
        public UInt16MultiArray()
        {
            layout = new RBS.Messages.std_msgs.MultiArrayLayout();
            data = new uint[0];
        }
    }
}