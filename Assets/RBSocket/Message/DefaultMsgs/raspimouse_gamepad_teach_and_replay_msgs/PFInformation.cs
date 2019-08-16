using System;

namespace RBS.Messages.raspimouse_gamepad_teach_and_replay_msgs
{
    [System.Serializable]
    public class PFInformation : ExtendMessage
    {
        public float eta;
        public uint[] positions;
        public override string Type() { return "raspimouse_gamepad_teach_and_replay_msgs/PFInformation"; }
        public PFInformation()
        {
            eta = 0.0f;
            positions = new uint[0];
        }
    }
}