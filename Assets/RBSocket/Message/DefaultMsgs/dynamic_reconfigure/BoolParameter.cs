using System;

namespace RBS.Messages.dynamic_reconfigure
{
    [System.Serializable]
    public class BoolParameter : ExtendMessage
    {
        public string name;
        public bool value;
        public override string Type() { return "dynamic_reconfigure/BoolParameter"; }
        public BoolParameter()
        {
            name = "";
            value = false;
        }
    }
}