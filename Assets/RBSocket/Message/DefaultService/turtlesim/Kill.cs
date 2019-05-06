using System;

namespace RBS.Messages.turtlesim
{
    [System.Serializable]
    public class KillRequest : ExtendMessage
    {
        public string name;
        public override string Type() { return "turtlesim/Kill"; }
        public KillRequest()
        {
            name = "";
        }
    }

    [System.Serializable]
    public class KillResponse : ExtendMessage
    {
        public override string Type() { return "turtlesim/Kill"; }
        public KillResponse()
        {
        }
    }
}