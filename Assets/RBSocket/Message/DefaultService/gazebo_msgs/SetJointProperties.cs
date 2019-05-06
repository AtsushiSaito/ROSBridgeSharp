using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class SetJointPropertiesRequest : ExtendMessage
    {
        public string joint_name;
        public RBS.Messages.gazebo_msgs.ODEJointProperties ode_joint_config;
        public override string Type() { return "gazebo_msgs/SetJointProperties"; }
        public SetJointPropertiesRequest()
        {
            joint_name = "";
            ode_joint_config = new RBS.Messages.gazebo_msgs.ODEJointProperties();
        }
    }

    [System.Serializable]
    public class SetJointPropertiesResponse : ExtendMessage
    {
        public bool success;
        public string status_message;
        public override string Type() { return "gazebo_msgs/SetJointProperties"; }
        public SetJointPropertiesResponse()
        {
            success = false;
            status_message = "";
        }
    }
}