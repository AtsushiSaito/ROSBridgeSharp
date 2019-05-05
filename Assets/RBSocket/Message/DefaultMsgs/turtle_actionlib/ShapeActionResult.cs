using System;

namespace RBS.Messages.turtle_actionlib
{
    [System.Serializable]
    public class ShapeActionResult : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalStatus status;
        public RBS.Messages.turtle_actionlib.ShapeResult result;
        public override string Type() { return "turtle_actionlib/ShapeActionResult"; }
        public ShapeActionResult()
        {
            header = new RBS.Messages.std_msgs.Header();
            status = new RBS.Messages.actionlib_msgs.GoalStatus();
            result = new RBS.Messages.turtle_actionlib.ShapeResult();
        }
    }
}