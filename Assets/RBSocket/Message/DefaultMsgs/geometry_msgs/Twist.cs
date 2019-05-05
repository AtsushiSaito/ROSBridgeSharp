using System;

namespace RBS.Messages.geometry_msgs
{
    [System.Serializable]
    public class Twist : ExtendMessage
    {
        public RBS.Messages.geometry_msgs.Vector3 linear;
        public RBS.Messages.geometry_msgs.Vector3 angular;
        public override string Type() { return "geometry_msgs/Twist"; }
        public Twist()
        {
            linear = new RBS.Messages.geometry_msgs.Vector3();
            angular = new RBS.Messages.geometry_msgs.Vector3();
        }
    }
}