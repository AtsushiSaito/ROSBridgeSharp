using System;

namespace RBS.Messages.raspimouse_gamepad_teach_and_replay
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
        public uint[] particles_pos;
        public override string Type() { return "raspimouse_gamepad_teach_and_replay/PFoEOutput"; }
        public PFoEOutput()
        {
            right_forward = 0;
            right_side = 0;
            left_side = 0;
            left_forward = 0;
            linear_x = 0.0f;
            angular_z = 0.0f;
            eta = 0.0f;
            particles_pos = new uint[0];
        }
    }
}