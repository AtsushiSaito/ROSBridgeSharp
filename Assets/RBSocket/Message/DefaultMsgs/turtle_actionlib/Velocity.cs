using System;

namespace RBS.Messages.turtle_actionlib
{
    [System.Serializable]
    public class Velocity : ExtendMessage
    {
        public float linear;
        public float angular;
        public override string Type() { return "turtle_actionlib/Velocity"; }
        public Velocity()
        {
            linear = 0.0f;
            angular = 0.0f;
        }
    }
}