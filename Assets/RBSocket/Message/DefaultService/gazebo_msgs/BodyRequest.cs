using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class BodyRequestRequest : ExtendMessage
    {
        public string body_name;
        public override string Type() { return "gazebo_msgs/BodyRequest"; }
        public BodyRequestRequest()
        {
            body_name = "";
        }
    }

    [System.Serializable]
    public class BodyRequestResponse : ExtendMessage
    {
        public override string Type() { return "gazebo_msgs/BodyRequest"; }
        public BodyRequestResponse()
        {
        }
    }
}