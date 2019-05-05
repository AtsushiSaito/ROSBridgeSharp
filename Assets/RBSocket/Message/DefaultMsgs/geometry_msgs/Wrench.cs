using System;

namespace RBS.Messages.geometry_msgs
{
    [System.Serializable]
    public class Wrench : ExtendMessage
    {
        public RBS.Messages.geometry_msgs.Vector3 force;
        public RBS.Messages.geometry_msgs.Vector3 torque;
        public override string Type() { return "geometry_msgs/Wrench"; }
        public Wrench()
        {
            force = new RBS.Messages.geometry_msgs.Vector3();
            torque = new RBS.Messages.geometry_msgs.Vector3();
        }
    }
}