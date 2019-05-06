using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class GetModelPropertiesRequest : ExtendMessage
    {
        public string model_name;
        public override string Type() { return "gazebo_msgs/GetModelProperties"; }
        public GetModelPropertiesRequest()
        {
            model_name = "";
        }
    }

    [System.Serializable]
    public class GetModelPropertiesResponse : ExtendMessage
    {
        public string parent_model_name;
        public string canonical_body_name;
        public string[] body_names;
        public string[] geom_names;
        public string[] joint_names;
        public string[] child_model_names;
        public bool is_static;
        public bool success;
        public string status_message;
        public override string Type() { return "gazebo_msgs/GetModelProperties"; }
        public GetModelPropertiesResponse()
        {
            parent_model_name = "";
            canonical_body_name = "";
            body_names = new string[0];
            geom_names = new string[0];
            joint_names = new string[0];
            child_model_names = new string[0];
            is_static = false;
            success = false;
            status_message = "";
        }
    }
}