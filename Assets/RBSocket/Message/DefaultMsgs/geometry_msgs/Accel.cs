using System;

namespace RBS.Messages.geometry_msgs
{
    [System.Serializable]
    public class Accel : ExtendMessage
    {
        public RBS.Messages.geometry_msgs.Vector3 linear;
        public RBS.Messages.geometry_msgs.Vector3 angular;
        public override string Type() { return "geometry_msgs/Accel"; }
        public Accel()
        {
            linear = new RBS.Messages.geometry_msgs.Vector3();
            angular = new RBS.Messages.geometry_msgs.Vector3();
        }
    }
}