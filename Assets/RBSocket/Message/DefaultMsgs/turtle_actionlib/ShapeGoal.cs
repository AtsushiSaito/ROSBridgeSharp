using System;

namespace RBS.Messages.turtle_actionlib
{
    [System.Serializable]
    public class ShapeGoal : ExtendMessage
    {
        public int edges;
        public float radius;
        public override string Type() { return "turtle_actionlib/ShapeGoal"; }
        public ShapeGoal()
        {
            edges = 0;
            radius = 0.0f;
        }
    }
}