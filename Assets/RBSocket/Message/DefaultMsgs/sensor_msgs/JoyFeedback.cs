using System;

namespace RBS.Messages.sensor_msgs
{
    [System.Serializable]
    public class JoyFeedback : ExtendMessage
    {
        public byte TYPE_LED;
        public byte TYPE_RUMBLE;
        public byte TYPE_BUZZER;
        public byte type;
        public byte id;
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