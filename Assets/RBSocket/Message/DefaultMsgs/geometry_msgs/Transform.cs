using System;

namespace RBS.Messages.geometry_msgs
{
    [System.Serializable]
    public class Transform : ExtendMessage
    {
        public RBS.Messages.geometry_msgs.Vector3 translation;
        public RBS.Messages.geometry_msgs.Quaternion rotation;
        public override string Type() { return "geometry_msgs/Transform"; }
        public Transform()
        {
            translation = new RBS.Messages.geometry_msgs.Vector3();
            rotation = new RBS.Messages.geometry_msgs.Quaternion();
        }
    }
}