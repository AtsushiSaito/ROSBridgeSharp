using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class SetModelConfigurationRequest : ExtendMessage
    {
        public string model_name;
        public string urdf_param_name;
        public string[] joint_names;
        public double[] joint_positions;
        public override string Type() { return "gazebo_msgs/SetModelConfiguration"; }
        public SetModelConfigurationRequest()
        {
            model_name = "";
            urdf_param_name = "";
            joint_names = new string[0];
            joint_positions = new double[0];
        }
    }

    [System.Serializable]
    public class SetModelConfigurationResponse : ExtendMessage
    {
        public bool success;
        public string status_message;
        public override string Type() { return "gazebo_msgs/SetModelConfiguration"; }
        public SetModelConfigurationResponse()
        {
            success = false;
            status_message = "";
        }
    }
}