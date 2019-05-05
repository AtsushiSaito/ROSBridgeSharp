using System;

namespace RBS.Messages.raspimouse_ros_2
{
    [System.Serializable]
    public class LedValues : ExtendMessage
    {
        public bool left_side;
        public bool left_forward;
        public bool right_forward;
        public bool right_side;
        public override string Type() { return "raspimouse_ros_2/LedValues"; }
        public LedValues()
        {
            left_side = false;
            left_forward = false;
            right_forward = false;
            right_side = false;
        }
    }
}