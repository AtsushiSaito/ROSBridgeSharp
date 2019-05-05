using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class FollowJointTrajectoryResult : ExtendMessage
    {
        public int SUCCESSFUL;
        public int INVALID_GOAL;
        public int INVALID_JOINTS;
        public int OLD_HEADER_TIMESTAMP;
        public int PATH_TOLERANCE_VIOLATED;
        public int GOAL_TOLERANCE_VIOLATED;
        public int error_code;
        public string error_string;
        public override string Type() { return "control_msgs/FollowJointTrajectoryResult"; }
        public FollowJointTrajectoryResult()
        {
            SUCCESSFUL = 0;
            INVALID_GOAL = -1;
            INVALID_JOINTS = -2;
            OLD_HEADER_TIMESTAMP = -3;
            PATH_TOLERANCE_VIOLATED = -4;
            GOAL_TOLERANCE_VIOLATED = -5;
            error_code = 0;
            error_string = "";
        }
    }
}