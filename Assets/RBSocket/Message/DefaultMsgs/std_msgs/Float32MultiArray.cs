using System;

namespace RBS.Messages.std_msgs
{
    [System.Serializable]
    public class Float32MultiArray : ExtendMessage
    {
        public RBS.Messages.std_msgs.MultiArrayLayout layout;
        public float[] data;
        public override string Type() { return "std_msgs/Float32MultiArray"; }
        public Float32MultiArray()
        {
            layout = new RBS.Messages.std_msgs.MultiArrayLayout();
            data = new float[0];
        }
    }
}