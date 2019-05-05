using System;

namespace RBS.Messages.turtlesim
{
    [System.Serializable]
    public class Color : ExtendMessage
    {
        public uint r;
        public uint g;
        public uint b;
        public override string Type() { return "turtlesim/Color"; }
        public Color()
        {
            r = 0;
            g = 0;
            b = 0;
        }
    }
}