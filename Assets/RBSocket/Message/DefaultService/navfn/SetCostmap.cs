using System;

namespace RBS.Messages.navfn
{
    [System.Serializable]
    public class SetCostmapRequest : ExtendMessage
    {
        public uint[] costs;
        public uint height;
        public uint width;
        public override string Type() { return "navfn/SetCostmap"; }
        public SetCostmapRequest()
        {
            costs = new uint[0];
            height = 0;
            width = 0;
        }
    }

    [System.Serializable]
    public class SetCostmapResponse : ExtendMessage
    {
        public override string Type() { return "navfn/SetCostmap"; }
        public SetCostmapResponse()
        {
        }
    }
}