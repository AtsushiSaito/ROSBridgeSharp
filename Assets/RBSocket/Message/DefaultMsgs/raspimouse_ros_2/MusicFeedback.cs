using System;

namespace RBS.Messages.raspimouse_ros_2
{
    [System.Serializable]
    public class MusicFeedback : ExtendMessage
    {
        public uint remaining_steps;
        public override string Type() { return "raspimouse_ros_2/MusicFeedback"; }
        public MusicFeedback()
        {
            remaining_steps = 0;
        }
    }
}