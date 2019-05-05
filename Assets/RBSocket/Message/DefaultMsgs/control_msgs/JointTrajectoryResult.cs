using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class JointTrajectoryResult : ExtendMessage
    {
        public override string Type() { return "control_msgs/JointTrajectoryResult"; }
        public JointTrajectoryResult()
        {
        }
    }
}