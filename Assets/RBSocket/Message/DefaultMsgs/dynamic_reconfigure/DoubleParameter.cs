using System;

namespace RBS.Messages.dynamic_reconfigure
{
    [System.Serializable]
    public class DoubleParameter : ExtendMessage
    {
        public string name;
        public double value;
        public override string Type() { return "dynamic_reconfigure/DoubleParameter"; }
        public DoubleParameter()
        {
            name = "";
            value = 0.0f;
        }
    }
}