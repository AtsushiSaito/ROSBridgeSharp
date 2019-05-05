using System;

namespace RBS.Messages.dynamic_reconfigure
{
    [System.Serializable]
    public class ParamDescription : ExtendMessage
    {
        public string name;
        public string type;
        public uint level;
        public string description;
        public string edit_method;
        public override string Type() { return "dynamic_reconfigure/ParamDescription"; }
        public ParamDescription()
        {
            name = "";
            type = "";
            level = 0;
            description = "";
            edit_method = "";
        }
    }
}