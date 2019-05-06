using System;

namespace RBS.Messages.turtlesim
{
    [System.Serializable]
    public class TeleportAbsoluteRequest : ExtendMessage
    {
        public float x;
        public float y;
        public float theta;
        public override string Type() { return "turtlesim/TeleportAbsolute"; }
        public TeleportAbsoluteRequest()
        {
            x = 0.0f;
            y = 0.0f;
            theta = 0.0f;
        }
    }

    [System.Serializable]
    public class TeleportAbsoluteResponse : ExtendMessage
    {
        public override string Type() { return "turtlesim/TeleportAbsolute"; }
        public TeleportAbsoluteResponse()
        {
        }
    }
}