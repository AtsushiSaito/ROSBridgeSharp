using System;

namespace RBS.Messages.raspimouse_ros_2
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
        public LightSensorValues()
        {
            right_forward = 0;
            right_side = 0;
            left_side = 0;
            left_forward = 0;
            sum_all = 0;
            sum_forward = 0;
        }
    }
}