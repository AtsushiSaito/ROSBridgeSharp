using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class GetWorldPropertiesRequest : ExtendMessage
    {
        public override string Type() { return "gazebo_msgs/GetWorldProperties"; }
        public GetWorldPropertiesRequest()
        {
        }
    }

    [System.Serializable]
    public class GetWorldPropertiesResponse : ExtendMessage
    {
        public double sim_time;
        public string[] model_names;
        public bool rendering_enabled;
        public bool success;
        public string status_message;
        public override string Type() { return "gazebo_msgs/GetWorldProperties"; }
        public GetWorldPropertiesResponse()
        {
            sim_time = 0.0f;
            model_names = new string[0];
            rendering_enabled = false;
            success = false;
            status_message = "";
        }
    }
}