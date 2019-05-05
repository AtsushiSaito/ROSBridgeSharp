using System;

namespace RBS.Messages.trajectory_msgs
{
    [System.Serializable]
    public class MultiDOFJointTrajectoryPoint : ExtendMessage
    {
        public RBS.Messages.geometry_msgs.Transform[] transforms;
        public RBS.Messages.geometry_msgs.Twist[] velocities;
        public RBS.Messages.geometry_msgs.Twist[] accelerations;
        public Duration time_from_start;
        public override string Type() { return "trajectory_msgs/MultiDOFJointTrajectoryPoint"; }
        public MultiDOFJointTrajectoryPoint()
        {
            transforms = new RBS.Messages.geometry_msgs.Transform[0];
            velocities = new RBS.Messages.geometry_msgs.Twist[0];
            accelerations = new RBS.Messages.geometry_msgs.Twist[0];
            time_from_start = new Duration();
        }
    }
}