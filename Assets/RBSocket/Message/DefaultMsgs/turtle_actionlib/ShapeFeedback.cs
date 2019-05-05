using System;

namespace RBS.Messages.turtle_actionlib
{
    [System.Serializable]
    public class ShapeFeedback : ExtendMessage
    {
        public override string Type() { return "turtle_actionlib/ShapeFeedback"; }
        public ShapeFeedback()
        {
        }
    }
}