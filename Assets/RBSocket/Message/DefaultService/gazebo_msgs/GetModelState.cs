using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class GetModelStateRequest : ExtendMessage
    {
        public string model_name;
        public string relative_entity_name;
        public override string Type() { return "gazebo_msgs/GetModelState"; }
        public GetModelStateRequest()
        {
            model_name = "";
            relative_entity_name = "";
        }
    }

    [System.Serializable]
    public class GetModelStateResponse : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.geometry_msgs.Pose pose;
        public RBS.Messages.geometry_msgs.Twist twist;
        public bool success;
        public string status_message;
        public override string Type() { return "gazebo_msgs/GetModelState"; }
        public GetModelStateResponse()
        {
            header = new RBS.Messages.std_msgs.Header();
            pose = new RBS.Messages.geometry_msgs.Pose();
            twist = new RBS.Messages.geometry_msgs.Twist();
            success = false;
            status_message = "";
        }
    }
}