using System;

namespace RBS.Messages.raspimouse_ros_2
{
    [System.Serializable]
    public class MotorFreqs : ExtendMessage
    {
        public int left_hz;
        public int right_hz;
        public override string Type() { return "raspimouse_ros_2/MotorFreqs"; }
        public MotorFreqs()
        {
            left_hz = 0;
            right_hz = 0;
        }
    }
}