using System;

namespace RBS.Messages.std_msgs
{
    [System.Serializable]
    public class ByteMultiArray : ExtendMessage
    {
        public RBS.Messages.std_msgs.MultiArrayLayout layout;
        public string data;
        public override string Type() { return "std_msgs/ByteMultiArray"; }
        public ByteMultiArray()
        {
            layout = new RBS.Messages.std_msgs.MultiArrayLayout();
            data = "";
        }
    }
}