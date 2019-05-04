using System;

namespace RBS.Messages
{
    [System.Serializable]
    public class PFoEOutput : ExtendMessage
    {
        public int right_forward;
        public int right_side;
        public int left_side;
        public int left_forward;

        public float linear_x;
        public float angular_z;
        public float eta;

        public int[] particles_pos;
        public override string Type() { return "raspimouse_gamepad_teach_and_replay/PFoEOutput"; }
    }
}