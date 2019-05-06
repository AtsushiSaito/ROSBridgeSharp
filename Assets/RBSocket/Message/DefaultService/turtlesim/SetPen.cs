using System;

namespace RBS.Messages.turtlesim
{
    [System.Serializable]
    public class SetPenRequest : ExtendMessage
    {
        public uint r;
        public uint g;
        public uint b;
        public uint width;
        public uint off;
        public override string Type() { return "turtlesim/SetPen"; }
        public SetPenRequest()
        {
            r = 0;
            g = 0;
            b = 0;
            width = 0;
            off = 0;
        }
    }

    [System.Serializable]
    public class SetPenResponse : ExtendMessage
    {
        public override string Type() { return "turtlesim/SetPen"; }
        public SetPenResponse()
        {
        }
    }
}