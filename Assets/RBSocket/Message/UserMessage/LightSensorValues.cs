using System;

namespace RBS.Messages
{
    [System.Serializable]
    public class LightSensorValues : ExtendMessage
    {
        public int right_forward;
        public int right_side;
        public int left_side;
        public int left_forward;
        public int sum_all;
        public int sum_forward;
        public override string Type() { return "raspimouse_ros_2/LightSensorValues"; }
    }
}