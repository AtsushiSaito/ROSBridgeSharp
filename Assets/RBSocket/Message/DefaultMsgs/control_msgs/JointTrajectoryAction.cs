using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class JointTrajectoryAction : ExtendMessage
    {
        public RBS.Messages.control_msgs.JointTrajectoryActionGoal action_goal;
        public RBS.Messages.control_msgs.JointTrajectoryActionResult action_result;
        public RBS.Messages.control_msgs.JointTrajectoryActionFeedback action_feedback;
        public override string Type() { return "control_msgs/JointTrajectoryAction"; }
        public JointTrajectoryAction()
        {
            action_goal = new RBS.Messages.control_msgs.JointTrajectoryActionGoal();
            action_result = new RBS.Messages.control_msgs.JointTrajectoryActionResult();
            action_feedback = new RBS.Messages.control_msgs.JointTrajectoryActionFeedback();
        }
    }
}