using System;

namespace RBS.Messages.dynamic_reconfigure
{
    [System.Serializable]
    public class ConfigDescription : ExtendMessage
    {
        public RBS.Messages.dynamic_reconfigure.Group[] groups;
        public RBS.Messages.dynamic_reconfigure.Config max;
        public RBS.Messages.dynamic_reconfigure.Config min;
        public RBS.Messages.dynamic_reconfigure.Config dflt;
        public override string Type() { return "dynamic_reconfigure/ConfigDescription"; }
        public ConfigDescription()
        {
            groups = new RBS.Messages.dynamic_reconfigure.Group[0];
            max = new RBS.Messages.dynamic_reconfigure.Config();
            min = new RBS.Messages.dynamic_reconfigure.Config();
            dflt = new RBS.Messages.dynamic_reconfigure.Config();
        }
    }
}