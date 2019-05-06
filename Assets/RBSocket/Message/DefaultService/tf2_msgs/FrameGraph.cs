using System;

namespace RBS.Messages.tf2_msgs
{
    [System.Serializable]
    public class FrameGraphRequest : ExtendMessage
    {
        public override string Type() { return "tf2_msgs/FrameGraph"; }
        public FrameGraphRequest()
        {
        }
    }

    [System.Serializable]
    public class FrameGraphResponse : ExtendMessage
    {
        public string frame_yaml;
        public override string Type() { return "tf2_msgs/FrameGraph"; }
        public FrameGraphResponse()
        {
            frame_yaml = "";
        }
    }
}