using System;

namespace RBS.Messages.geometry_msgs
{
    [System.Serializable]
    public class TransformStamped : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public string child_frame_id;
        public RBS.Messages.geometry_msgs.Transform transform;
        public override string Type() { return "geometry_msgs/TransformStamped"; }
        public TransformStamped()
        {
            header = new RBS.Messages.std_msgs.Header();
            child_frame_id = "";
            transform = new RBS.Messages.geometry_msgs.Transform();
        }
    }
}