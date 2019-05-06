using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class JointRequestRequest : ExtendMessage
    {
        public string joint_name;
        public override string Type() { return "gazebo_msgs/JointRequest"; }
        public JointRequestRequest()
        {
            joint_name = "";
        }
    }

    [System.Serializable]
    public class JointRequestResponse : ExtendMessage
    {
        public override string Type() { return "gazebo_msgs/JointRequest"; }
        public JointRequestResponse()
        {
        }
    }
}