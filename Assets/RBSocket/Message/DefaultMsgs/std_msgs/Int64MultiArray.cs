using System;

namespace RBS.Messages.std_msgs
{
    [System.Serializable]
    public class Int64MultiArray : ExtendMessage
    {
        public RBS.Messages.std_msgs.MultiArrayLayout layout;
        public int[] data;
        public override string Type() { return "std_msgs/Int64MultiArray"; }
        public Int64MultiArray()
        {
            layout = new RBS.Messages.std_msgs.MultiArrayLayout();
            data = new int[0];
        }
    }
}