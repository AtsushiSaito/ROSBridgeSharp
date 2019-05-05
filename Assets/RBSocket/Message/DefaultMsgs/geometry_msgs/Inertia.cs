using System;

namespace RBS.Messages.geometry_msgs
{
    [System.Serializable]
    public class Inertia : ExtendMessage
    {
        public double m;
        public RBS.Messages.geometry_msgs.Vector3 com;
        public double ixx;
        public double ixy;
        public double ixz;
        public double iyy;
        public double iyz;
        public double izz;
        public override string Type() { return "geometry_msgs/Inertia"; }
        public Inertia()
        {
            m = 0.0f;
            com = new RBS.Messages.geometry_msgs.Vector3();
            ixx = 0.0f;
            ixy = 0.0f;
            ixz = 0.0f;
            iyy = 0.0f;
            iyz = 0.0f;
            izz = 0.0f;
        }
    }
}