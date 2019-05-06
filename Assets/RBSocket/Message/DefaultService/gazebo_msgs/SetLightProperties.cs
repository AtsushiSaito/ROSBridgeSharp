using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class SetLightPropertiesRequest : ExtendMessage
    {
        public string light_name;
        public RBS.Messages.std_msgs.ColorRGBA diffuse;
        public double attenuation_constant;
        public double attenuation_linear;
        public double attenuation_quadratic;
        public override string Type() { return "gazebo_msgs/SetLightProperties"; }
        public SetLightPropertiesRequest()
        {
            light_name = "";
            diffuse = new RBS.Messages.std_msgs.ColorRGBA();
            attenuation_constant = 0.0f;
            attenuation_linear = 0.0f;
            attenuation_quadratic = 0.0f;
        }
    }

    [System.Serializable]
    public class SetLightPropertiesResponse : ExtendMessage
    {
        public bool success;
        public string status_message;
        public override string Type() { return "gazebo_msgs/SetLightProperties"; }
        public SetLightPropertiesResponse()
        {
            success = false;
            status_message = "";
        }
    }
}