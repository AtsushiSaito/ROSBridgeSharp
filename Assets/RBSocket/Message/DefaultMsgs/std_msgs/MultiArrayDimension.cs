using System;

namespace RBS.Messages.std_msgs
{
    [System.Serializable]
    public class MultiArrayDimension : ExtendMessage
    {
        public string label;
        public uint size;
        public uint stride;
        public override string Type() { return "std_msgs/MultiArrayDimension"; }
        public MultiArrayDimension()
        {
            label = "";
            size = 0;
            stride = 0;
        }
    }
}