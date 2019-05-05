using System;

namespace RBS.Messages.shape_msgs
{
    [System.Serializable]
    public class SolidPrimitive : ExtendMessage
    {
        public uint BOX;
        public uint SPHERE;
        public uint CYLINDER;
        public uint CONE;
        public uint BOX_X;
        public uint BOX_Y;
        public uint BOX_Z;
        public uint SPHERE_RADIUS;
        public uint CYLINDER_HEIGHT;
        public uint CYLINDER_RADIUS;
        public uint CONE_HEIGHT;
        public uint CONE_RADIUS;
        public uint type;
        public double[] dimensions;
        public override string Type() { return "shape_msgs/SolidPrimitive"; }
        public SolidPrimitive()
        {
            BOX = 1;
            SPHERE = 2;
            CYLINDER = 3;
            CONE = 4;
            BOX_X = 0;
            BOX_Y = 1;
            BOX_Z = 2;
            SPHERE_RADIUS = 0;
            CYLINDER_HEIGHT = 0;
            CYLINDER_RADIUS = 1;
            CONE_HEIGHT = 0;
            CONE_RADIUS = 1;
            type = 0;
            dimensions = new double[0];
        }
    }
}