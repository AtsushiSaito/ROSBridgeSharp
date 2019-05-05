using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class JointTrajectoryControllerState : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public string[] joint_names;
        public RBS.Messages.trajectory_msgs.JointTrajectoryPoint desired;
        public RBS.Messages.trajectory_msgs.JointTrajectoryPoint actual;
        public RBS.Messages.trajectory_msgs.JointTrajectoryPoint error;
        public override string Type() { return "control_msgs/JointTrajectoryControllerState"; }
        public JointTrajectoryControllerState()
        {
            header = new RBS.Messages.std_msgs.Header();
            joint_names = new string[0];
            desired = new RBS.Messages.trajectory_msgs.JointTrajectoryPoint();
            actual = new RBS.Messages.trajectory_msgs.JointTrajectoryPoint();
            error = new RBS.Messages.trajectory_msgs.JointTrajectoryPoint();
        }
    }
}