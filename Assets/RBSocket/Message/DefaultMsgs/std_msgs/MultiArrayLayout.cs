using System;

namespace RBS.Messages.std_msgs
{
    [System.Serializable]
    public class MultiArrayLayout : ExtendMessage
    {
        public RBS.Messages.std_msgs.MultiArrayDimension[] dim;
        public uint data_offset;
        public override string Type() { return "std_msgs/MultiArrayLayout"; }
        public MultiArrayLayout()
        {
            dim = new RBS.Messages.std_msgs.MultiArrayDimension[0];
            data_offset = 0;
        }
    }
}