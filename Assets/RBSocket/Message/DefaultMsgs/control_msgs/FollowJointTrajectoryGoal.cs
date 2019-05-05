using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class FollowJointTrajectoryGoal : ExtendMessage
    {
        public RBS.Messages.trajectory_msgs.JointTrajectory trajectory;
        public RBS.Messages.control_msgs.JointTolerance[] path_tolerance;
        public RBS.Messages.control_msgs.JointTolerance[] goal_tolerance;
        public Duration goal_time_tolerance;
        public override string Type() { return "control_msgs/FollowJointTrajectoryGoal"; }
        public FollowJointTrajectoryGoal()
        {
            trajectory = new RBS.Messages.trajectory_msgs.JointTrajectory();
            path_tolerance = new RBS.Messages.control_msgs.JointTolerance[0];
            goal_tolerance = new RBS.Messages.control_msgs.JointTolerance[0];
            goal_time_tolerance = new Duration();
        }
    }
}