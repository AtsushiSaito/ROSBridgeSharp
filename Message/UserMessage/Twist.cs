using System;

namespace ROSBridgeSharp.Messages
{
    [System.Serializable]
    public class Twist : Message
    {
        public Vector3 linear;
        public Vector3 angular;
    }
}