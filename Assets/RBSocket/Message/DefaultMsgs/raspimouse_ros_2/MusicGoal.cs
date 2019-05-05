using System;

namespace RBS.Messages.raspimouse_ros_2
{
    [System.Serializable]
    public class MusicGoal : ExtendMessage
    {
        public uint[] freqs;
        public float[] durations;
        public override string Type() { return "raspimouse_ros_2/MusicGoal"; }
        public MusicGoal()
        {
            freqs = new uint[0];
            durations = new float[0];
        }
    }
}