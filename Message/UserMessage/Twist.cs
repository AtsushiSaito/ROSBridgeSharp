using System;

namespace ROSBridgeSharp.Messages
{
    [System.Serializable]
    public class Twist : ExtendMessage
    {
        public Vector3 linear;
        public Vector3 angular;
        public override string Type() { return "geometry_msgs/Twist"; }
    }
}