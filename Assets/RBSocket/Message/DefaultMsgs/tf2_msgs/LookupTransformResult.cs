using System;

namespace RBS.Messages.tf2_msgs
{
    [System.Serializable]
    public class LookupTransformResult : ExtendMessage
    {
        public RBS.Messages.geometry_msgs.TransformStamped transform;
        public RBS.Messages.tf2_msgs.TF2Error error;
        public override string Type() { return "tf2_msgs/LookupTransformResult"; }
        public LookupTransformResult()
        {
            transform = new RBS.Messages.geometry_msgs.TransformStamped();
            error = new RBS.Messages.tf2_msgs.TF2Error();
        }
    }
}