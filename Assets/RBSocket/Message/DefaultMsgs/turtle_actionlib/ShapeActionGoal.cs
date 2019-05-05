using System;

namespace RBS.Messages.turtle_actionlib
{
    [System.Serializable]
    public class ShapeActionGoal : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalID goal_id;
        public RBS.Messages.turtle_actionlib.ShapeGoal goal;
        public override string Type() { return "turtle_actionlib/ShapeActionGoal"; }
        public ShapeActionGoal()
        {
            header = new RBS.Messages.std_msgs.Header();
            goal_id = new RBS.Messages.actionlib_msgs.GoalID();
            goal = new RBS.Messages.turtle_actionlib.ShapeGoal();
        }
    }
}