using System;

namespace RBS.Messages.tf2_msgs
{
    [System.Serializable]
    public class TFMessage : ExtendMessage
    {
        public RBS.Messages.geometry_msgs.TransformStamped[] transforms;
        public override string Type() { return "tf2_msgs/TFMessage"; }
        public TFMessage()
        {
            transforms = new RBS.Messages.geometry_msgs.TransformStamped[0];
        }
    }
}