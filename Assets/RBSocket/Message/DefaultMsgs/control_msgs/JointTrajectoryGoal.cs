using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class JointTrajectoryGoal : ExtendMessage
    {
        public RBS.Messages.trajectory_msgs.JointTrajectory trajectory;
        public override string Type() { return "control_msgs/JointTrajectoryGoal"; }
        public JointTrajectoryGoal()
        {
            trajectory = new RBS.Messages.trajectory_msgs.JointTrajectory();
        }
    }
}