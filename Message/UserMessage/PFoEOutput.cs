using System;

namespace ROSBridgeSharp.Messages
{
    [System.Serializable]
    public class PFoEOutput : Message
    {
        public int right_forward;
        public int right_side;
        public int left_side;
        public int left_forward;

        public float linear_x;
        public float angular_z;
        public float eta;

        public int[] particles_pos;
    }
}