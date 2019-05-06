using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class SpawnModelRequest : ExtendMessage
    {
        public string model_name;
        public string model_xml;
        public string robot_namespace;
        public RBS.Messages.geometry_msgs.Pose initial_pose;
        public string reference_frame;
        public override string Type() { return "gazebo_msgs/SpawnModel"; }
        public SpawnModelRequest()
        {
            model_name = "";
            model_xml = "";
            robot_namespace = "";
            initial_pose = new RBS.Messages.geometry_msgs.Pose();
            reference_frame = "";
        }
    }

    [System.Serializable]
    public class SpawnModelResponse : ExtendMessage
    {
        public bool success;
        public string status_message;
        public override string Type() { return "gazebo_msgs/SpawnModel"; }
        public SpawnModelResponse()
        {
            success = false;
            status_message = "";
        }
    }
}