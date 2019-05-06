using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class DeleteModelRequest : ExtendMessage
    {
        public string model_name;
        public override string Type() { return "gazebo_msgs/DeleteModel"; }
        public DeleteModelRequest()
        {
            model_name = "";
        }
    }

    [System.Serializable]
    public class DeleteModelResponse : ExtendMessage
    {
        public bool success;
        public string status_message;
        public override string Type() { return "gazebo_msgs/DeleteModel"; }
        public DeleteModelResponse()
        {
            success = false;
            status_message = "";
        }
    }
}