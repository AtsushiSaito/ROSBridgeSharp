using System;

namespace RBS.Messages.dynamic_reconfigure
{
    [System.Serializable]
    public class Config : ExtendMessage
    {
        public RBS.Messages.dynamic_reconfigure.BoolParameter[] bools;
        public RBS.Messages.dynamic_reconfigure.IntParameter[] ints;
        public RBS.Messages.dynamic_reconfigure.StrParameter[] strs;
        public RBS.Messages.dynamic_reconfigure.DoubleParameter[] doubles;
        public RBS.Messages.dynamic_reconfigure.GroupState[] groups;
        public override string Type() { return "dynamic_reconfigure/Config"; }
        public Config()
        {
            bools = new RBS.Messages.dynamic_reconfigure.BoolParameter[0];
            ints = new RBS.Messages.dynamic_reconfigure.IntParameter[0];
            strs = new RBS.Messages.dynamic_reconfigure.StrParameter[0];
            doubles = new RBS.Messages.dynamic_reconfigure.DoubleParameter[0];
            groups = new RBS.Messages.dynamic_reconfigure.GroupState[0];
        }
    }
}