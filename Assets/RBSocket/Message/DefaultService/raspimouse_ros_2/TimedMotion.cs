using System;

namespace RBS.Messages.raspimouse_ros_2
{
    [System.Serializable]
    public class TimedMotionRequest : ExtendMessage
    {
        public int left_hz;
        public int right_hz;
        public uint duration_ms;
        public override string Type() { return "raspimouse_ros_2/TimedMotion"; }
        public TimedMotionRequest()
        {
            left_hz = 0;
            right_hz = 0;
            duration_ms = 0;
        }
    }

    [System.Serializable]
    public class TimedMotionResponse : ExtendMessage
    {
        public bool success;
        public override string Type() { return "raspimouse_ros_2/TimedMotion"; }
        public TimedMotionResponse()
        {
            success = false;
        }
    }
}