using System;

namespace RBS.Messages.tf
{
    [System.Serializable]
    public class tfMessage : ExtendMessage
    {
        public RBS.Messages.geometry_msgs.TransformStamped[] transforms;
        public override string Type() { return "tf/tfMessage"; }
        public tfMessage()
        {
            transforms = new RBS.Messages.geometry_msgs.TransformStamped[0];
        }
    }
}