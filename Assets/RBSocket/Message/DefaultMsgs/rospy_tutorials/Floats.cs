using System;

namespace RBS.Messages.rospy_tutorials
{
    [System.Serializable]
    public class Floats : ExtendMessage
    {
        public float[] data;
        public override string Type() { return "rospy_tutorials/Floats"; }
        public Floats()
        {
            data = new float[0];
        }
    }
}