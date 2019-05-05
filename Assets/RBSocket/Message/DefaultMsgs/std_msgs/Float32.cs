using System;

namespace RBS.Messages.std_msgs
{
    [System.Serializable]
    public class Float32 : ExtendMessage
    {
        public float data;
        public override string Type() { return "std_msgs/Float32"; }
        public Float32()
        {
            data = 0.0f;
        }
    }
}