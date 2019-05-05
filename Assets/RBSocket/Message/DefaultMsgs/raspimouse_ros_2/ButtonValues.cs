using System;

namespace RBS.Messages.raspimouse_ros_2
{
    [System.Serializable]
    public class ButtonValues : ExtendMessage
    {
        public bool front;
        public bool mid;
        public bool rear;
        public bool front_toggle;
        public bool mid_toggle;
        public bool rear_toggle;
        public override string Type() { return "raspimouse_ros_2/ButtonValues"; }
        public ButtonValues()
        {
            front = false;
            mid = false;
            rear = false;
            front_toggle = false;
            mid_toggle = false;
            rear_toggle = false;
        }
    }
}