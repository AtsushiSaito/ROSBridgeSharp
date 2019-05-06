using System;

namespace RBS.Messages.turtlesim
{
    [System.Serializable]
    public class TeleportRelativeRequest : ExtendMessage
    {
        public float linear;
        public float angular;
        public override string Type() { return "turtlesim/TeleportRelative"; }
        public TeleportRelativeRequest()
        {
            linear = 0.0f;
            angular = 0.0f;
        }
    }

    [System.Serializable]
    public class TeleportRelativeResponse : ExtendMessage
    {
        public override string Type() { return "turtlesim/TeleportRelative"; }
        public TeleportRelativeResponse()
        {
        }
    }
}