using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class DeleteLightRequest : ExtendMessage
    {
        public string light_name;
        public override string Type() { return "gazebo_msgs/DeleteLight"; }
        public DeleteLightRequest()
        {
            light_name = "";
        }
    }

    [System.Serializable]
    public class DeleteLightResponse : ExtendMessage
    {
        public bool success;
        public string status_message;
        public override string Type() { return "gazebo_msgs/DeleteLight"; }
        public DeleteLightResponse()
        {
            success = false;
            status_message = "";
        }
    }
}