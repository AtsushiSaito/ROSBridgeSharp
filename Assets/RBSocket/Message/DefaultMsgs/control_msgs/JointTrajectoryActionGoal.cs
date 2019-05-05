using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class JointTrajectoryActionGoal : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalID goal_id;
        public RBS.Messages.control_msgs.JointTrajectoryGoal goal;
        public override string Type() { return "control_msgs/JointTrajectoryActionGoal"; }
        public JointTrajectoryActionGoal()
        {
            header = new RBS.Messages.std_msgs.Header();
            goal_id = new RBS.Messages.actionlib_msgs.GoalID();
            goal = new RBS.Messages.control_msgs.JointTrajectoryGoal();
        }
    }
}