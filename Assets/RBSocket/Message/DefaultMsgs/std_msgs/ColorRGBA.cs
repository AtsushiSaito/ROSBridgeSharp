using System;

namespace RBS.Messages.std_msgs
{
    [System.Serializable]
    public class ColorRGBA : ExtendMessage
    {
        public float r;
        public float g;
        public float b;
        public float a;
        public override string Type() { return "std_msgs/ColorRGBA"; }
        public ColorRGBA()
        {
            r = 0.0f;
            g = 0.0f;
            b = 0.0f;
            a = 0.0f;
        }
    }
}