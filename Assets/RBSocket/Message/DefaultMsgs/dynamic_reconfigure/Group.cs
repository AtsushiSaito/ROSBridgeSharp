using System;

namespace RBS.Messages.dynamic_reconfigure
{
    [System.Serializable]
    public class Group : ExtendMessage
    {
        public string name;
        public string type;
        public RBS.Messages.dynamic_reconfigure.ParamDescription[] parameters;
        public int parent;
        public int id;
        public override string Type() { return "dynamic_reconfigure/Group"; }
        public Group()
        {
            name = "";
            type = "";
            parameters = new RBS.Messages.dynamic_reconfigure.ParamDescription[0];
            parent = 0;
            id = 0;
        }
    }
}