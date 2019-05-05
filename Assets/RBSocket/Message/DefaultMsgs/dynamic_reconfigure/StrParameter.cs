using System;

namespace RBS.Messages.dynamic_reconfigure
{
    [System.Serializable]
    public class StrParameter : ExtendMessage
    {
        public string name;
        public string value;
        public override string Type() { return "dynamic_reconfigure/StrParameter"; }
        public StrParameter()
        {
            name = "";
            value = "";
        }
    }
}