using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class SetModelStateRequest : ExtendMessage
    {
        public RBS.Messages.gazebo_msgs.ModelState model_state;
        public override string Type() { return "gazebo_msgs/SetModelState"; }
        public SetModelStateRequest()
        {
            model_state = new RBS.Messages.gazebo_msgs.ModelState();
        }
    }

    [System.Serializable]
    public class SetModelStateResponse : ExtendMessage
    {
        public bool success;
        public string status_message;
        public override string Type() { return "gazebo_msgs/SetModelState"; }
        public SetModelStateResponse()
        {
            success = false;
            status_message = "";
        }
    }
}