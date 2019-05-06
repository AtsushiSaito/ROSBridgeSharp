using System;

namespace RBS.Messages.turtlesim
{
    [System.Serializable]
    public class SpawnRequest : ExtendMessage
    {
        public float x;
        public float y;
        public float theta;
        public string name;
        public override string Type() { return "turtlesim/Spawn"; }
        public SpawnRequest()
        {
            x = 0.0f;
            y = 0.0f;
            theta = 0.0f;
            name = "";
        }
    }

    [System.Serializable]
    public class SpawnResponse : ExtendMessage
    {
        public string name;
        public override string Type() { return "turtlesim/Spawn"; }
        public SpawnResponse()
        {
            name = "";
        }
    }
}