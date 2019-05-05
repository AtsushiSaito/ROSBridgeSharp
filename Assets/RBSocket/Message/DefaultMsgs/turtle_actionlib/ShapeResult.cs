using System;

namespace RBS.Messages.turtle_actionlib
{
    [System.Serializable]
    public class ShapeResult : ExtendMessage
    {
        public float interior_angle;
        public float apothem;
        public override string Type() { return "turtle_actionlib/ShapeResult"; }
        public ShapeResult()
        {
            interior_angle = 0.0f;
            apothem = 0.0f;
        }
    }
}