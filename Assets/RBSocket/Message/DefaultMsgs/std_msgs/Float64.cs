using System;

namespace RBS.Messages.std_msgs
{
    [System.Serializable]
    public class Float64 : ExtendMessage
    {
        public double data;
        public override string Type() { return "std_msgs/Float64"; }
        public Float64()
        {
            data = 0.0f;
        }
    }
}