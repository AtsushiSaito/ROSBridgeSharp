using System;

namespace RBS.Messages.geometry_msgs
{
    [System.Serializable]
    public class Pose : ExtendMessage
    {
        public RBS.Messages.geometry_msgs.Point position;
        public RBS.Messages.geometry_msgs.Quaternion orientation;
        public override string Type() { return "geometry_msgs/Pose"; }
        public Pose()
        {
            position = new RBS.Messages.geometry_msgs.Point();
            orientation = new RBS.Messages.geometry_msgs.Quaternion();
        }
    }
}