using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class GetLinkPropertiesRequest : ExtendMessage
    {
        public string link_name;
        public override string Type() { return "gazebo_msgs/GetLinkProperties"; }
        public GetLinkPropertiesRequest()
        {
            link_name = "";
        }
    }

    [System.Serializable]
    public class GetLinkPropertiesResponse : ExtendMessage
    {
        public RBS.Messages.geometry_msgs.Pose com;
        public bool gravity_mode;
        public double mass;
        public double ixx;
        public double ixy;
        public double ixz;
        public double iyy;
        public double iyz;
        public double izz;
        public bool success;
        public string status_message;
        public override string Type() { return "gazebo_msgs/GetLinkProperties"; }
        public GetLinkPropertiesResponse()
        {
            com = new RBS.Messages.geometry_msgs.Pose();
            gravity_mode = false;
            mass = 0.0f;
            ixx = 0.0f;
            ixy = 0.0f;
            ixz = 0.0f;
            iyy = 0.0f;
            iyz = 0.0f;
            izz = 0.0f;
            success = false;
            status_message = "";
        }
    }
}