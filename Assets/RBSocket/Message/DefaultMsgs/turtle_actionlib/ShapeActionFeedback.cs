using System;

namespace RBS.Messages.turtle_actionlib
{
    [System.Serializable]
    public class ShapeActionFeedback : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalStatus status;
        public RBS.Messages.turtle_actionlib.ShapeFeedback feedback;
        public override string Type() { return "turtle_actionlib/ShapeActionFeedback"; }
        public ShapeActionFeedback()
        {
            header = new RBS.Messages.std_msgs.Header();
            status = new RBS.Messages.actionlib_msgs.GoalStatus();
            feedback = new RBS.Messages.turtle_actionlib.ShapeFeedback();
        }
    }
}