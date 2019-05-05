using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class FollowJointTrajectoryActionResult : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalStatus status;
        public RBS.Messages.control_msgs.FollowJointTrajectoryResult result;
        public override string Type() { return "control_msgs/FollowJointTrajectoryActionResult"; }
        public FollowJointTrajectoryActionResult()
        {
            header = new RBS.Messages.std_msgs.Header();
            status = new RBS.Messages.actionlib_msgs.GoalStatus();
            result = new RBS.Messages.control_msgs.FollowJointTrajectoryResult();
        }
    }
}