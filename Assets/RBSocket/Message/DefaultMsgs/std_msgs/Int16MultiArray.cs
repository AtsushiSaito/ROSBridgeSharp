using System;

namespace RBS.Messages.std_msgs
{
    [System.Serializable]
    public class Int16MultiArray : ExtendMessage
    {
        public RBS.Messages.std_msgs.MultiArrayLayout layout;
        public int[] data;
        public override string Type() { return "std_msgs/Int16MultiArray"; }
        public Int16MultiArray()
        {
            layout = new RBS.Messages.std_msgs.MultiArrayLayout();
            data = new int[0];
        }
    }
}