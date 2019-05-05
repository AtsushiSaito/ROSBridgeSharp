using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class PointHeadFeedback : ExtendMessage
    {
        public double pointing_angle_error;
        public override string Type() { return "control_msgs/PointHeadFeedback"; }
        public PointHeadFeedback()
        {
            pointing_angle_error = 0.0f;
        }
    }
}