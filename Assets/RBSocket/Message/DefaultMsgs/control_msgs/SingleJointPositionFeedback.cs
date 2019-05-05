using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class SingleJointPositionFeedback : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public double position;
        public double velocity;
        public double error;
        public override string Type() { return "control_msgs/SingleJointPositionFeedback"; }
        public SingleJointPositionFeedback()
        {
            header = new RBS.Messages.std_msgs.Header();
            position = 0.0f;
            velocity = 0.0f;
            error = 0.0f;
        }
    }
}