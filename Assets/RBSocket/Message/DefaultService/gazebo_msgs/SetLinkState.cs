using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class SetLinkStateRequest : ExtendMessage
    {
        public RBS.Messages.gazebo_msgs.LinkState link_state;
        public override string Type() { return "gazebo_msgs/SetLinkState"; }
        public SetLinkStateRequest()
        {
            link_state = new RBS.Messages.gazebo_msgs.LinkState();
        }
    }

    [System.Serializable]
    public class SetLinkStateResponse : ExtendMessage
    {
        public bool success;
        public string status_message;
        public override string Type() { return "gazebo_msgs/SetLinkState"; }
        public SetLinkStateResponse()
        {
            success = false;
            status_message = "";
        }
    }
}