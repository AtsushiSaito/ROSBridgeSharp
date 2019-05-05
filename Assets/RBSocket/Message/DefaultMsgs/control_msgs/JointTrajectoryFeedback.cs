using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class JointTrajectoryFeedback : ExtendMessage
    {
        public override string Type() { return "control_msgs/JointTrajectoryFeedback"; }
        public JointTrajectoryFeedback()
        {
        }
    }
}