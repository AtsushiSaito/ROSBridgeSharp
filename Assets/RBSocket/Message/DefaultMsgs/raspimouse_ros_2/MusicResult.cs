using System;

namespace RBS.Messages.raspimouse_ros_2
{
    [System.Serializable]
    public class MusicResult : ExtendMessage
    {
        public bool finished;
        public override string Type() { return "raspimouse_ros_2/MusicResult"; }
        public MusicResult()
        {
            finished = false;
        }
    }
}