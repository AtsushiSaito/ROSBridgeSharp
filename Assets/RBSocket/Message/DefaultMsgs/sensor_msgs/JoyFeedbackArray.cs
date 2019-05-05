using System;

namespace RBS.Messages.sensor_msgs
{
    [System.Serializable]
    public class JoyFeedbackArray : ExtendMessage
    {
        public RBS.Messages.sensor_msgs.JoyFeedback[] array;
        public override string Type() { return "sensor_msgs/JoyFeedbackArray"; }
        public JoyFeedbackArray()
        {
            array = new RBS.Messages.sensor_msgs.JoyFeedback[0];
        }
    }
}