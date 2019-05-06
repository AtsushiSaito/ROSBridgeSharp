using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class ApplyJointEffortRequest : ExtendMessage
    {
        public string joint_name;
        public double effort;
        public Time start_time;
        public Duration duration;
        public override string Type() { return "gazebo_msgs/ApplyJointEffort"; }
        public ApplyJointEffortRequest()
        {
            joint_name = "";
            effort = 0.0f;
            start_time = new Time();
            duration = new Duration();
        }
    }

    [System.Serializable]
    public class ApplyJointEffortResponse : ExtendMessage
    {
        public bool success;
        public string status_message;
        public override string Type() { return "gazebo_msgs/ApplyJointEffort"; }
        public ApplyJointEffortResponse()
        {
            success = false;
            status_message = "";
        }
    }
}