using System;

namespace RBS.Messages.dynamic_reconfigure
{
    [System.Serializable]
    public class IntParameter : ExtendMessage
    {
        public string name;
        public int value;
        public override string Type() { return "dynamic_reconfigure/IntParameter"; }
        public IntParameter()
        {
            name = "";
            value = 0;
        }
    }
}