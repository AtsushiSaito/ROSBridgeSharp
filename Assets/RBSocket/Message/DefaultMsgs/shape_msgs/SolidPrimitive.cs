using System;

namespace RBS.Messages.shape_msgs
{
    [System.Serializable]
    public class SolidPrimitive : ExtendMessage
    {
        public byte BOX;
        public byte SPHERE;
        public byte CYLINDER;
        public byte CONE;
        public byte BOX_X;
        public byte BOX_Y;
        public byte BOX_Z;
        public byte SPHERE_RADIUS;
        public byte CYLINDER_HEIGHT;
        public byte CYLINDER_RADIUS;
        public byte CONE_HEIGHT;
        public byte CONE_RADIUS;
        public byte type;
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