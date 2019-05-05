using System;

namespace RBS.Messages.trajectory_msgs
{
    [System.Serializable]
    public class JointTrajectoryPoint : ExtendMessage
    {
        public double[] positions;
        public double[] velocities;
        public double[] accelerations;
        public double[] effort;
        public Duration time_from_start;
        public override string Type() { return "trajectory_msgs/JointTrajectoryPoint"; }
        public JointTrajectoryPoint()
        {
            positions = new double[0];
            velocities = new double[0];
            accelerations = new double[0];
            effort = new double[0];
            time_from_start = new Duration();
        }
    }
}