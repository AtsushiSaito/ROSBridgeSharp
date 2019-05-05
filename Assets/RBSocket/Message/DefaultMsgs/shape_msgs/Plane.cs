using System;

namespace RBS.Messages.shape_msgs
{
    [System.Serializable]
    public class Plane : ExtendMessage
    {
        public double[] coef;
        public override string Type() { return "shape_msgs/Plane"; }
        public Plane()
        {
            coef = new double[4];
        }
    }
}