using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class GetLightPropertiesRequest : ExtendMessage
    {
        public string light_name;
        public override string Type() { return "gazebo_msgs/GetLightProperties"; }
        public GetLightPropertiesRequest()
        {
            light_name = "";
        }
    }

    [System.Serializable]
    public class GetLightPropertiesResponse : ExtendMessage
    {
        public RBS.Messages.std_msgs.ColorRGBA diffuse;
        public double attenuation_constant;
        public double attenuation_linear;
        public double attenuation_quadratic;
        public bool success;
        public string status_message;
        public override string Type() { return "gazebo_msgs/GetLightProperties"; }
        public GetLightPropertiesResponse()
        {
            diffuse = new RBS.Messages.std_msgs.ColorRGBA();
            attenuation_constant = 0.0f;
            attenuation_linear = 0.0f;
            attenuation_quadratic = 0.0f;
            success = false;
            status_message = "";
        }
    }
}