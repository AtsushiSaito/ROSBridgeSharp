using System;

namespace RBS.Messages.std_msgs
{
    [System.Serializable]
    public class UInt32MultiArray : ExtendMessage
    {
        public RBS.Messages.std_msgs.MultiArrayLayout layout;
        public uint[] data;
        public override string Type() { return "std_msgs/UInt32MultiArray"; }
        public UInt32MultiArray()
        {
            layout = new RBS.Messages.std_msgs.MultiArrayLayout();
            data = new uint[0];
        }
    }
}