using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class GetLinkStateRequest : ExtendMessage
    {
        public string link_name;
        public string reference_frame;
        public override string Type() { return "gazebo_msgs/GetLinkState"; }
        public GetLinkStateRequest()
        {
            link_name = "";
            reference_frame = "";
        }
    }

    [System.Serializable]
    public class GetLinkStateResponse : ExtendMessage
    {
        public RBS.Messages.gazebo_msgs.LinkState link_state;
        public bool success;
        public string status_message;
        public override string Type() { return "gazebo_msgs/GetLinkState"; }
        public GetLinkStateResponse()
        {
            link_state = new RBS.Messages.gazebo_msgs.LinkState();
            success = false;
            status_message = "";
        }
    }
}