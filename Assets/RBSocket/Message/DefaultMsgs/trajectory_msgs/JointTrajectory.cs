using System;

namespace RBS.Messages.trajectory_msgs
{
    [System.Serializable]
    public class JointTrajectory : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public string[] joint_names;
        public RBS.Messages.trajectory_msgs.JointTrajectoryPoint[] points;
        public override string Type() { return "trajectory_msgs/JointTrajectory"; }
        public JointTrajectory()
        {
            header = new RBS.Messages.std_msgs.Header();
            joint_names = new string[0];
            points = new RBS.Messages.trajectory_msgs.JointTrajectoryPoint[0];
        }
    }
}