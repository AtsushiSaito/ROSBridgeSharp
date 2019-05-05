using System;

namespace RBS.Messages.sensor_msgs
{
    [System.Serializable]
    public class JoyFeedback : ExtendMessage
    {
        public uint TYPE_LED;
        public uint TYPE_RUMBLE;
        public uint TYPE_BUZZER;
        public uint type;
        public uint id;
        public float intensity;
        public override string Type() { return "sensor_msgs/JoyFeedback"; }
        public JoyFeedback()
        {
            TYPE_LED = 0;
            TYPE_RUMBLE = 1;
            TYPE_BUZZER = 2;
            type = 0;
            id = 0;
            intensity = 0.0f;
        }
    }
}