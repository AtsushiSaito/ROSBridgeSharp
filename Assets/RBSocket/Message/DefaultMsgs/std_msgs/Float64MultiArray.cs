using System;

namespace RBS.Messages.std_msgs
{
    [System.Serializable]
    public class Float64MultiArray : ExtendMessage
    {
        public RBS.Messages.std_msgs.MultiArrayLayout layout;
        public double[] data;
        public override string Type() { return "std_msgs/Float64MultiArray"; }
        public Float64MultiArray()
        {
            layout = new RBS.Messages.std_msgs.MultiArrayLayout();
            data = new double[0];
        }
    }
}