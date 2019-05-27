using System;

namespace RBS.Messages.raspimouse_odometry_tuning
{
    [System.Serializable]
    public class CalibrationValue : ExtendMessage
    {
        public float forward_R;
        public float forward_L;
        public float back_R;
        public float back_L;
        public float right_R;
        public float right_L;
        public float left_R;
        public float left_L;
        public override string Type() { return "raspimouse_odometry_tuning/CalibrationValue"; }
        public CalibrationValue()
        {
            forward_R = 0.0f;
            forward_L = 0.0f;
            back_R = 0.0f;
            back_L = 0.0f;
            right_R = 0.0f;
            right_L = 0.0f;
            left_R = 0.0f;
            left_L = 0.0f;
        }
    }
}