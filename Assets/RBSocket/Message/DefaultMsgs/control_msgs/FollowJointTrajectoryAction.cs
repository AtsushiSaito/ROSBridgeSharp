using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class FollowJointTrajectoryAction : ExtendMessage
    {
        public RBS.Messages.control_msgs.FollowJointTrajectoryActionGoal action_goal;
        public RBS.Messages.control_msgs.FollowJointTrajectoryActionResult action_result;
        public RBS.Messages.control_msgs.FollowJointTrajectoryActionFeedback action_feedback;
        public override string Type() { return "control_msgs/FollowJointTrajectoryAction"; }
        public FollowJointTrajectoryAction()
        {
            action_goal = new RBS.Messages.control_msgs.FollowJointTrajectoryActionGoal();
            action_result = new RBS.Messages.control_msgs.FollowJointTrajectoryActionResult();
            action_feedback = new RBS.Messages.control_msgs.FollowJointTrajectoryActionFeedback();
        }
    }
}